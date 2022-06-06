

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

using System.Text.Json;

using Miniblog.Core.Models;


namespace Miniblog.Core.Services
{
    public class FileBlogJsonDataService : IBlogService
    {
        private const string FILES = "files";

        private const string POSTS = "Posts";

        private readonly List<Post> cache = new List<Post>();

        private readonly IHttpContextAccessor contextAccessor;

        private readonly string folder;


        public FileBlogJsonDataService(IWebHostEnvironment env, IHttpContextAccessor contextAccessor)
        {
            if (env is null)
            {
                throw new ArgumentNullException(nameof(env));
            }

            this.folder = Path.Combine(env.WebRootPath, POSTS);
            this.contextAccessor = contextAccessor;

            this.Initialize();
        }

        public Task DeletePost(Post post)
        {
            if (post is null)
            {
                throw new ArgumentNullException(nameof(post));
            }

            var filePath = this.GetFilePath(post);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            if (this.cache.Contains(post))
            {
                this.cache.Remove(post);
            }

            return Task.CompletedTask;
        }


        public virtual List<string> GetCategories()
        {
            var isAdmin = this.IsAdmin();

            return this.cache
                .Where(p => p.IsPublished || isAdmin)
                .SelectMany(post => post.Categories)
                .Select(cat => cat.ToLowerInvariant())
                .Distinct()
                .ToList();
        }

        public virtual Task<Post> GetPostById(string id)
        {
            var isAdmin = this.IsAdmin();
            var post = this.cache.FirstOrDefault(p => p.ID.Equals(id, StringComparison.OrdinalIgnoreCase));

            return Task.FromResult(
                post is null || post.PubDate > DateTime.UtcNow || (!post.IsPublished && !isAdmin)
                ? null
                : post);
        }

        public virtual Task<Post> GetPostBySlug(string slug)
        {
            var isAdmin = this.IsAdmin();
            var post = this.cache.FirstOrDefault(p => p.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));

            return Task.FromResult(
                post is null || post.PubDate > DateTime.UtcNow || (!post.IsPublished && !isAdmin)
                ? null
                : post);
        }

        /// <remarks>Overload for getPosts method to retrieve all posts.</remarks>
        public virtual List<Post> GetPosts()
        {
            var isAdmin = this.IsAdmin();

            var posts = this.cache
                .Where(p => p.PubDate <= DateTime.UtcNow && (p.IsPublished || isAdmin))
                .ToList();

            return posts;
        }

        public virtual List<Post> GetPosts(int count, int skip = 0)
        {
            var isAdmin = this.IsAdmin();

            var posts = this.cache
                .Where(p => p.PubDate <= DateTime.UtcNow && (p.IsPublished || isAdmin))
                .Skip(skip)
                .Take(count)
                .ToList();

            return posts;
        }

        public virtual List<Post> GetPostsByCategory(string category)
        {
            var isAdmin = this.IsAdmin();

            var posts = from p in this.cache
                        where p.PubDate <= DateTime.UtcNow && (p.IsPublished || isAdmin)
                        where p.Categories.Contains(category, StringComparer.OrdinalIgnoreCase)
                        select p;

            return posts.ToList();
        }


        public async Task<string> SaveFile(byte[] bytes, string fileName, string suffix = null)
        {
            if (bytes is null)
            {
                throw new ArgumentNullException(nameof(bytes));
            }

            suffix = CleanFromInvalidChars(suffix ?? DateTime.UtcNow.Ticks.ToString(CultureInfo.InvariantCulture));

            var ext = Path.GetExtension(fileName);
            var name = CleanFromInvalidChars(Path.GetFileNameWithoutExtension(fileName));

            var fileNameWithSuffix = $"{name}_{suffix}{ext}";

            var absolute = Path.Combine(this.folder, FILES, fileNameWithSuffix);
            var dir = Path.GetDirectoryName(absolute);

            Directory.CreateDirectory(dir);
            using (var writer = new FileStream(absolute, FileMode.CreateNew))
            {
                await writer.WriteAsync(bytes, 0, bytes.Length).ConfigureAwait(false);
                 writer.Close();
            }

            return $"/{POSTS}/{FILES}/{fileNameWithSuffix}";
        }

        public async Task SavePost(Post post)
        {
            if (post is null)
            {
                throw new ArgumentNullException(nameof(post));
            }

            var filePath = this.GetFilePath(post);
            post.LastModified = DateTime.UtcNow;

            

            //using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
            //{

                // Serialize and save

                var serializedData = JsonSerializer.Serialize(post);

               
                await File.WriteAllTextAsync(filePath, serializedData);

               
            //}

            if (!this.cache.Contains(post))
            {
                this.cache.Add(post);
                this.SortCache();
            }
        }

        protected bool IsAdmin() => this.contextAccessor.HttpContext?.User?.Identity.IsAuthenticated == true;

        protected void SortCache() => this.cache.Sort((p1, p2) => p2.PubDate.CompareTo(p1.PubDate));

        private static string CleanFromInvalidChars(string input)
        {
            // ToDo: what we are doing here if we switch the blog from windows to unix system or
            // vice versa? we should remove all invalid chars for both systems

            var regexSearch = Regex.Escape(new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars()));
            var r = new Regex($"[{regexSearch}]");
            return r.Replace(input, string.Empty);
        }

        private static string FormatDateTime(DateTime dateTime)
        {
            const string UTC = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'";

            return dateTime.Kind == DateTimeKind.Utc
                ? dateTime.ToString(UTC, CultureInfo.InvariantCulture)
                : dateTime.ToUniversalTime().ToString(UTC, CultureInfo.InvariantCulture);
        }

        private static void LoadCategories(Post post, XElement doc)
        {
            var categories = doc.Element("categories");
            if (categories is null)
            {
                return;
            }

            post.Categories.Clear();
            categories.Elements("category").Select(node => node.Value).ToList().ForEach(post.Categories.Add);
        }

        private static void LoadComments(Post post, XElement doc)
        {
            var comments = doc.Element("comments");

            if (comments is null)
            {
                return;
            }

            foreach (var node in comments.Elements("comment"))
            {
                var comment = new Comment
                {
                    ID = ReadAttribute(node, "id"),
                    Author = ReadValue(node, "author"),
                    Email = ReadValue(node, "email"),
                    IsAdmin = bool.Parse(ReadAttribute(node, "isAdmin", "false")),
                    Content = ReadValue(node, "content"),
                    PubDate = DateTime.Parse(ReadValue(node, "date", "2000-01-01"),
                        CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal),
                };

                post.Comments.Add(comment);
            }
        }

        private static string ReadAttribute(XElement element, XName name, string defaultValue = "") =>
            element.Attribute(name) is null ? defaultValue : element.Attribute(name)?.Value ?? defaultValue;

        private static string ReadValue(XElement doc, XName name, string defaultValue = "") =>
            doc.Element(name) is null ? defaultValue : doc.Element(name)?.Value ?? defaultValue;

        private string GetFilePath(Post post) => Path.Combine(this.folder, $"{post.ID}.xml");

        private void Initialize()
        {
            this.LoadPosts();
            this.SortCache();
        }


        private void LoadPosts()
        {
            if (!Directory.Exists(this.folder))
            {
                Directory.CreateDirectory(this.folder);
            }

            // Can this be done in parallel to speed it up?
            foreach (var file in Directory.EnumerateFiles(this.folder, "*.xml", SearchOption.TopDirectoryOnly))
            {
               

                // Read and deserialize
                var rawData = File.ReadAllText(file);
                var post = JsonSerializer.Deserialize<Post>(rawData);

              

                //LoadCategories(post, doc);
                //LoadComments(post, doc);
                this.cache.Add(post);
            }
        }
    }

}


