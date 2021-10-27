using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Miniblog.Core.Models;



namespace Miniblog.Core.Services
{
    public interface IBlogService
    {

        Task DeletePost(Post post);

        List<string> GetCategories();

        Task<Post> GetPostById(string id);

        Task<Post> GetPostBySlug(string slug);

        List<Post> GetPosts();

        List<Post> GetPosts(int count, int skip = 0);

        List<Post> GetPostsByCategory(string category);

        Task<string> SaveFile(byte[] bytes, string fileName, string suffix = null);

        Task SavePost(Post post);

    }
}
