# Blog engine for ASP.NET Core 6.x

A full-featured yet simple blog engine built on ASP.NET Core 6.x.

## project information

local：ctyun disk D:\developer_mini_core

github:https://github.com/iaspnetcore/MiniBlog.Core.git

domain:miniblog.iaspnetcore.com on vultr



[![Build status](https://ci.appveyor.com/api/projects/status/lwjrlpvmhg50wwbs?svg=true)](https://ci.appveyor.com/project/madskristensen/miniblog-core)
[![NuGet](https://img.shields.io/nuget/v/MadsKristensen.AspNetCore.Miniblog.svg)](https://nuget.org/packages/MadsKristensen.AspNetCore.Miniblog/)

[![Deploy to Azure](http://azuredeploy.net/deploybutton.png)](https://azuredeploy.net/)


Blog https://www.iaspnetcore.com/blogpost-5ec055705d065d499b65df13-how-to-create-a-miniblogcore-project-with-net6x-step-by-step

Create a ViewComponents https://docs.microsoft.com/en-us/aspnet/core/mvc/views/view-components?view=aspnetcore-6.0

Theme templates come from:https://getbootstrap.com/docs/5.1/examples/blog/#

**Live demo**: <https://miniblog.iaspnetcore.com/>  
Username: *demo*  
Password: *demo*

![Editor](art/editor.png)

### Custom themes
In search for custom designed themes for MiniBlog.Core? [Click here](https://francis.bio/miniblog-themes/).

1.buy domain

2.buy server

3. A to server

4. install nginx

5. config nginx for your domain

6.install Let’s Encrypt client certbot

7.downloaded SSL certificates for your domain


没有账号的点我注册Vultr账号（注册就送20美元哦）https://www.vultr.com/?ref=7035322-3B

Vultr注册购买图文教程 [Click here](https://www.vpsss.net/298.html).

## Features
- How to Deploy a New Instance on Vultr Step by Step (https://www.iaspnetcore.com/blogpost-6199ff495b26cb0202ad6ce8-how-to-deploy-a-new-instance-on-vultr-step-by-step)
- How To Install and uninstall reinstall Nginx on Ubuntu 18.04（aliyun）(https://www.iaspnetcore.com/blogpost-5d9865cc72c1772b244afe0f-how-to-install-and-uninstall-reinstall-nginx-on-ubuntu-1804aliyun)
- How to Install and uninstall reinstall  upgrade .NET 6.x on Ubuntu 18.04*64 step by step https://www.iaspnetcore.com/blogpost-618a75d3635c733c81dc77c3-how-to-install-net-6x-on-ubuntu-180464-step-by-step
- How to Deploying Real World ASP.NET Core 6.x on Ubuntu 18.04 step by step(vultr) https://www.iaspnetcore.com/blogpost-5f8791eb6cd85f05bcad2df1-how-to-deploying-real-world-aspnet-core-6x-on-ubuntu-1804-step-by-step
- All major browsers fully supported (IE 9+)
- Social media integration (Facebook, Twitter, Google+)
- Lazy loads images for better performance
- Easy YouTube video embedding
- Looks great when printed
- Works offline with use of [Service Worker](https://developers.google.com/web/fundamentals/primers/service-workers/)
- Follows best practices for web applications
  - [See DareBoost report](https://www.dareboost.com/en/report/59e928f10cf224d151dfbe2d)

## Technical features
- High performance. Gets 100/100 points on Google PageSpeed Insights 
  - [Run PageSpeed Insights](https://developers.google.com/speed/pagespeed/insights/?url=https%3A%2F%2Fminiblogcore.azurewebsites.net%2F)
- Speed Index < 1000
  - [See WebPageTest](http://www.webpagetest.org/result/170928_1R_cf91bb2d800cc389821c5cfa7e353f0d/) 
- Meets highest accessibility standards 
  - [Run accessibility validator](http://wave.webaim.org/report#/https://miniblogcore.azurewebsites.net/)
- W3C standards compliant 
  - [Run HTML validator](https://html5.validator.nu/?doc=https%3A%2F%2Fminiblogcore.azurewebsites.net%2F)
  - [Run RSS validator](https://validator.w3.org/feed/check.cgi?url=https%3A%2F%2Fminiblogcore.azurewebsites.net%2Ffeed%2Frss%2F)
- Responsive web design
  - [See mobile emulators](https://www.responsinator.com/?url=https%3A%2F%2Fminiblogcore.azurewebsites.net%2F)
- Mobile friendly
  - [Run Mobile-Friendly Test](https://search.google.com/test/mobile-friendly?id=i4i-jw3VafvYnjcyHt4jgg)
- Schema.org support with HTML 5 Microdata 
  - [Run testing tool](https://search.google.com/structured-data/testing-tool#url=https%3A%2F%2Fminiblogcore.azurewebsites.net%2F)
- OpenGraph support for Facebook, Twitter, Pinterest and more
  - [Run Facebook validator](https://developers.facebook.com/tools/debug/sharing/?q=https%3A%2F%2Fminiblogcore.azurewebsites.net%2F)
  - [Check the tags](http://opengraphcheck.com/result.php?url=https%3A%2F%2Fminiblogcore.azurewebsites.net%2F#.WdhRDjBlB3g)
- Seach engine optimized
  - [Run SEO Site Checkup](https://seositecheckup.com/seo-audit/miniblogcore.azurewebsites.net)
- Security HTTP headers set
  - [Run security scan](https://securityheaders.io/?q=https%3A%2F%2Fminiblogcore.azurewebsites.net%2F&hide=on&followRedirects=on)
- Uses the [Azure Image Optimizer](https://github.com/madskristensen/ImageOptimizerWebJob) for superb image compression
- Uses a [CDN Tag Helper](https://github.com/madskristensen/WebEssentials.AspNetCore.CdnTagHelpers) to make it easy to serve the images from any CDN.

### YouTube embeds
You can embed any youtube video by using the following syntax in the source of a blog post:

```
[youtube:ScXvuavqhzo]
```

*ScXvuavqhzo* is the ID of the YouTube video which can be found in any YouTube link looking this *youtube.com/watch?v=**ScXvuavqhzo***

## How to use
On the command line, install the template.

```cmd
dotnet new --install MadsKristensen.AspNetCore.Miniblog
```

Then create it into any folder.

```cmd
dotnet new miniblog
```

Then run it or open it in Visual Studio or your favorite code editor.

```cmd
dotnet run
```

## Credits
SVG icons by <https://simpleicons.org/>



### miniblog.iaspnetcore.com服务器配置

     miniblog.iaspnetcore.com服务器配置

1.miniblog.iaspnetcore.com

命令行启动

~~~
Debug

sudo systemctl stop kestrel-miniblogiaspnetcorecom.service

cd /
cd /var/www/MiniBlog.Core/src/Miniblog.Core

dotnet run --urls http://0.0.0.0:6002

dotnet run --urls http://localhost:6002


Release

sudo systemctl stop kestrel-miniblogiaspnetcorecom.service


cd /var/www/MiniBlog.Core/src/Miniblog.Core

dotnet publish -c release


cd /var/www/MiniBlog.Core/src/Miniblog.Core/bin/Release/net6.0/publish/

dotnet Miniblog.Core.dll  --urls http://127.0.0.1:6002


~~~

2.服务配置

sudo vi /etc/systemd/system/kestrel-miniblogiaspnetcorecom.service

path:/etc/systemd/system/kestrel-miniblogiaspnetcorecom.service

kestrel-miniblogiaspnetcorecom.service

~~~
[Unit]
Description=miniblog.iaspnetcore.com App running on Ubuntu

[Service]
WorkingDirectory=/var/www/MiniBlog.Core/src/Miniblog.Core/bin/Release/net6.0/publish
ExecStart=/usr/bin/dotnet /var/www/MiniBlog.Core/src/Miniblog.Core/bin/Release/net6.0/publish/Miniblog.Core.dll --urls http://127.0.0.1:6002
Restart=always
# Restart service after 10 seconds if the dotnet service crashes:
RestartSec=10
KillSignal=SIGINT
SyslogIdentifier=miniblog.iaspnetcore.com
User=www-data
Environment=ASPNETCORE_ENVIRONMENT=Production
Environment=DOTNET_PRINT_TELEMETRY_MESSAGE=false

[Install]
WantedBy=multi-user.target

~~~


3.Install first kestrel-miniblogiaspnetcorecom.service

~~~
sudo systemctl daemon-reload 
sudo systemctl enable kestrel-miniblogiaspnetcorecom.service
sudo systemctl start kestrel-miniblogiaspnetcorecom.service
sudo systemctl status kestrel-miniblogiaspnetcorecom.service


sudo systemctl restart kestrel-miniblogiaspnetcorecom.service
sudo systemctl stop kestrel-miniblogiaspnetcorecom.service
sudo systemctl status kestrel-miniblogiaspnetcorecom.service

sudo journalctl -fu kestrel-miniblogiaspnetcorecom.service



sudo systemctl restart kestrel-miniblogiaspnetcorecom.service


~~~

4.批处理

~~~
cp  -r /var/www/nopcommerce/wwwiaspnetcorecom/src/Presentation/Nop.Web/bin/release/net5.0/publish/wwwroot/uploadimages  /var/www/nopcommerce/wwwiaspnetcorecom/src/Presentation/Nop.Web/wwwroot/uploadimages

sudo systemctl stop kestrel-wwwiaspnetcorecom.service

cd /
cd var/www/nopcommerce/wwwiaspnetcorecom/src/Presentation/Nop.Web
dotnet publish -c release

sudo systemctl daemon-reload 
sudo systemctl restart kestrel-wwwiaspnetcorecom.service

~~~
