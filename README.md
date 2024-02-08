# Blog engine for ASP.NET Core 8.x

miniblog.iaspnetcore.com

A full-featured yet simple blog engine built on ASP.NET Core 8.x.  bootstrap 5.x + json data + .net 8.x

## project git information

20221126  


local disk; f:\developer_mini_core_json



github:https://github.com/iaspnetcore/MiniBlog.Core.git

domain:miniblog.iaspnetcore.com on vultr


\src\Miniblog.Core\wwwroot\Posts\files
\src\Miniblog.Core\wwwroot\Posts


Blog https://www.iaspnetcore.com/blogpost-5ec055705d065d499b65df13-how-to-create-a-miniblogcore-project-with-net6x-step-by-step

CRUD Operation With JSON File Data In C#

https://www.iaspnetcore.com/blogpost-629d3d6d0cdc850252550b72-crud-operation-with-json-file-data-in-c

Create a ViewComponents https://docs.microsoft.com/en-us/aspnet/core/mvc/views/view-components?view=aspnetcore-6.0

Theme templates come from:https://getbootstrap.com/docs/5.1/examples/blog/#

**Live demo**: <https://miniblog.iaspnetcore.com/>  
Username: *demo*  
Password: *demo*



### Custom themes


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

- Follows best practices for web applications
  - [See DareBoost report](https://www.dareboost.com/en/report/59e928f10cf224d151dfbe2d)

## buy domain
- Buy a domain from www.namesilo.com 
  - [www.namesilo.com](https://www.iaspnetcore.com/Blog/BlogPost/5eb9e65e775d020216dbe009/wwwnamesilocom-registration-and-domain-name-purchase-operation-manual)
- Change Name Servers dns
  - [Change Name Servers dns  to cf](https://www.iaspnetcore.com/Blog/BlogPost/5eb9e65e775d020216dbe009/wwwnamesilocom-registration-and-domain-name-purchase-operation-manual#mcetoc_1g2fliou61l) 
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



## How to use
On the command line

```cmd

cd /
cd /var/www/iaspnetcore/developer_mini_core_json_miniblogiaspnetcorecom/developer_mini_core_json/src/Miniblog.Core

dotnet run --urls http://0.0.0.0:6002

dotnet run --urls http://localhost:6002

```

output

~~~

info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:6002
dbug: Microsoft.AspNetCore.Hosting.Diagnostics[13]
      Loaded hosting startup assembly Miniblog.Core
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]



~~~




### miniblog.iaspnetcore.com服务器配置

     miniblog.iaspnetcore.com服务器配置

1.miniblog.iaspnetcore.com

命令行启动

~~~
Debug

sudo systemctl stop kestrel-miniblogiaspnetcorecom.service

cd /
cd /var/www/iaspnetcore/developer_mini_core_json_miniblogiaspnetcorecom/developer_mini_core_json/src/Miniblog.Core


dotnet run --urls http://0.0.0.0:6002

dotnet run --urls http://localhost:6002


Release

sudo systemctl stop kestrel-miniblogiaspnetcorecom.service


cd /var/www/iaspnetcore/developer_mini_core_json_miniblogiaspnetcorecom/developer_mini_core_json/src/Miniblog.Core

dotnet publish -c release

Output

~~~
 Miniblog.Core -> /var/www/iaspnetcore/developer_mini_core_json_miniblogiaspnetcorecom/developer_mini_core_json/src/Miniblog.Core/bin/Release/net8.0/Miniblog.Core.dll
  Adding WebOptimizer cache files to publish output
  Miniblog.Core -> /var/www/iaspnetcore/developer_mini_core_json_miniblogiaspnetcorecom/developer_mini_core_json/src/Miniblog.Core/bin/Release/net8.0/publish/

~~~


cd /var/www/iaspnetcore/developer_mini_core_json_miniblogiaspnetcorecom/developer_mini_core_json/src/Miniblog.Core/bin/Release/net8.0/publish/

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
WorkingDirectory=/var/www/MiniBlog.Core/src/Miniblog.Core/bin/Release/net8.0/publish
ExecStart=/usr/bin/dotnet /var/www/MiniBlog.Core/src/Miniblog.Core/bin/Release/net8.0/publish/Miniblog.Core.dll --urls http://localhost:6002
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
cp  -r /var/www/MiniBlog.Core/src/Miniblog.Core/bin/Release/net8.0/publish/wwwroot/uploadimages  /var/www/MiniBlog.Core/src/Miniblog.Core/src/wwwroot/uploadimages



sudo systemctl stop kestrel-miniblogiaspnetcorecom.service

cd /
cd /var/www/MiniBlog.Core/src/Miniblog.Core
dotnet publish -c release

sudo systemctl daemon-reload 
sudo systemctl restart kestrel-miniblogiaspnetcorecom.service

~~~

~~~
chmod 777 /var/artifacts
chmode 777 /var/www/MiniBlog.Core/src/Miniblog.Core/bin/Release/net8.0/publish/wwwroot/Posts



~~~