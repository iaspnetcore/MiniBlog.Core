# Blog engine for ASP.NET Core 9.x

miniblog.iaspnetcore.com

A full-featured yet simple blog engine built on ASP.NET Core 8.x.  bootstrap 5.x + json data + .net 8.x.

I have a vps on vultr.com running Ubuntu, and installed ASP.NET Core 8.x  many months ago.

Browser Cloudflare Origin Server http://localhost:7600  full mode

## project git information

20221126  


local disk: f:\developer_mini_core_json



github:https://github.com/iaspnetcore/MiniBlog.Core.git

domain:miniblog.iaspnetcore.com on vultr


\src\Miniblog.Core\wwwroot\Posts\files
\src\Miniblog.Core\wwwroot\Posts


Blog 

Miniblog.Core Project:How to Create a Miniblog.Core Project with .Net 6.x step by step
https://www.iaspnetcore.com/blogpost-5ec055705d065d499b65df13-how-to-create-a-miniblogcore-project-with-net6x-step-by-step

Miniblog.Core Project:ASP.NET Core 6.x-W3CLogger  
https://www.iaspnetcore.com/Blog/BlogPost/618aaa94635c733c81e1486d/miniblogcore-projectaspnet-core-6x-w3clogger

CRUD Operation With JSON File Data In C#

https://www.iaspnetcore.com/blogpost-629d3d6d0cdc850252550b72-crud-operation-with-json-file-data-in-c

Create a ViewComponents https://docs.microsoft.com/en-us/aspnet/core/mvc/views/view-components?view=aspnetcore-6.0

Theme templates come from:https://getbootstrap.com/docs/5.1/examples/blog/#

**Live demo**: <https://miniblog.iaspnetcore.com/>  
Username: *demo*  
Password: *demo*



## Quick Start


1.buy domain

2.buy server

3.A to server

4.install nginx

5.config nginx for your domain

6.install Let��s Encrypt client certbot

7.downloaded SSL certificates for your domain

8.run local web server

## Quick Start


1. A Linux domain is available on the Vultr. Also see docker/README.md

2.A Linux server is available on the Vultr. Also see docker/README.md

3.A to server

4.install nginx   here(https://www.iaspnetcore.com/Blog/BlogPost/5d9865cc72c1772b244afe0f/how-to-install-and-uninstall-reinstall-nginx-on-ubuntu-1804aliyunvultr)

5.config nginx for your domain

6.install Let��s Encrypt client certbot

7.downloaded SSL certificates for your domain

8.run local web server





û���˺ŵĵ���ע��Vultr�˺ţ�ע�����20��ԪŶ��https://www.vultr.com/?ref=7035322-3B

Vultrע�Ṻ��ͼ�Ľ̳� [Click here](https://www.vpsss.net/298.html).




## Features
- How to Deploy a New Instance on Vultr Step by Step (https://www.iaspnetcore.com/blogpost-6199ff495b26cb0202ad6ce8-how-to-deploy-a-new-instance-on-vultr-step-by-step)
- How To Install and uninstall reinstall Nginx on Ubuntu 18.04��aliyun��(https://www.iaspnetcore.com/blogpost-5d9865cc72c1772b244afe0f-how-to-install-and-uninstall-reinstall-nginx-on-ubuntu-1804aliyun)
- How to Install and uninstall reinstall  upgrade .NET 6.x on Ubuntu 18.04*64 step by step https://www.iaspnetcore.com/blogpost-618a75d3635c733c81dc77c3-how-to-install-net-6x-on-ubuntu-180464-step-by-step
- How to Deploying Real World ASP.NET Core 6.x on Ubuntu 18.04 step by step(vultr) https://www.iaspnetcore.com/blogpost-5f8791eb6cd85f05bcad2df1-how-to-deploying-real-world-aspnet-core-6x-on-ubuntu-1804-step-by-step

- Follows best practices for web applications
  - [See DareBoost report](https://www.dareboost.com/en/report/59e928f10cf224d151dfbe2d)

## buy domain
- Log in to your domain registrar
  - [www.namesilo.com](https://www.iaspnetcore.com/Blog/BlogPost/5eb9e65e775d020216dbe009/wwwnamesilocom-registration-and-domain-name-purchase-operation-manual) -Buy a domain from www.namesilo.com 
- Update your nameservers - change your default Nameservers to Cloudflare Nameservers
  - [Change Name Servers dns  to cf](https://www.iaspnetcore.com/Blog/BlogPost/5eb9e65e775d020216dbe009/wwwnamesilocom-registration-and-domain-name-purchase-operation-manual#mcetoc_1g2fliou61l) - Find the list of nameservers at your registrar. Add both of your assigned Cloudflare nameservers, remove any other nameservers, and save your changes.Change Name Servers dns  to cf
## buy server
- buy server from vultr.com 
  - [buy server](https://www.iaspnetcore.com/blogpost-6199ff495b26cb0202ad6ce8-how-to-deploy-a-new-instance-on-vultr-step-by-step)
- W3C standards compliant 
  - [Run HTML validator](https://html5.validator.nu/?doc=https%3A%2F%2Fminiblogcore.azurewebsites.net%2F)
  - [Run RSS validator](https://validator.w3.org/feed/check.cgi?url=https%3A%2F%2Fminiblogcore.azurewebsites.net%2Ffeed%2Frss%2F)
## cloudflare
- cloudflare login
  - [cloudflare login](https://www.iaspnetcore.com/Blog/BlogPost/5ee3a43a1c73d43127f113a1/cloudflare-free-cdn-website-acceleration-practical-tutorial-1-registration-dns-resolution-records) -  register  with Cloudflare Register.
- Add Site
  - [Add Site](https://www.iaspnetcore.com/Blog/BlogPost/5ee3a43a1c73d43127f113a1/cloudflare-free-cdn-website-acceleration-practical-tutorial-1-registration-dns-resolution-records#mcetoc_1g37gn9lfv) - Add your Site to cloudflare
- Create DNS records - Add an A and AAAA record for your website
  - [Create DNS records](https://www.iaspnetcore.com/Blog/BlogPost/6450b5b069967f028dbd9414/using-lets-encrypt-certbot-with-cloudflares-reverse-proxy) - For A, AAAA records, decide whether hostname traffic is proxied through Cloudflare.
- SSL/TLS encryption mode is Full, Encrypts traffic between the browser and Cloudflare,Cloudflare  and Origin Server
  - [SSL/TLS encryption mode is Full](https://www.iaspnetcore.com/Blog/BlogPost/6450b5b069967f028dbd9414/using-lets-encrypt-certbot-with-cloudflares-reverse-proxy) - Full Encrypts end-to-end, using a self signed certificate on the server
## nginx server on vps
- Install and uninstall reinstall Nginx on Ubuntu 18.04
  - [How To Install and uninstall reinstall Nginx on Ubuntu 18.04��aliyun/vultr](https://developers.facebook.com/tools/debug/sharing/?q=https%3A%2F%2Fminiblogcore.azurewebsites.net%2F)
  - [nginx configure](https://www.iaspnetcore.com/Blog/BlogPost/5c32197c1d51ae0eec5613be/deployment-of-https-combat-series-6-generation-and-modification-of-lets-encrypt-free-certificate-aliyun-ubuntu-1604-64bit)
- Let's Encrypt
  - [Let's Encrypt:How to Secure Nginx with Let��s Encrypt on Ubuntu 18.04(vultr)](https://www.iaspnetcore.com/blogpost-619a0dbd5b26cb0202ae5bf1-lets-encrypthow-to-secure-nginx-with-lets-encrypt-on-ubuntu-1804vultr)
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




### miniblog.iaspnetcore.com����������

     miniblog.iaspnetcore.com����������

1.miniblog.iaspnetcore.com

����������

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

2.��������

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

4.������

~~~
cp  -r /var/www/MiniBlog.Core/src/Miniblog.Core/bin/Release/net8.0/publish/wwwroot/uploadimages  /var/www/MiniBlog.Core/src/Miniblog.Core/src/wwwroot/uploadimages



sudo systemctl stop kestrel-miniblogiaspnetcorecom.service

cd /
cd /var/www/MiniBlog.Core/src/Miniblog.Core
dotnet publish -c release

sudo systemctl daemon-reload 
sudo systemctl restart kestrel-miniblogiaspnetcorecom.service

~~~

 System.UnauthorizedAccessException: Access to the path '/var/www/Miniblog.Core/Miniblog.Core/src/bin/Release/net8.0/publish/obj' is denied.
 System.UnauthorizedAccessException: Access to the path '/var/www/Miniblog.Core/src/bin/Release/net8.0/publish/wwwroot/Posts/638056233411122802.json' is denied.


~~~
chmod 777 /var/artifacts
chmode 777 /var/www/MiniBlog.Core/src/Miniblog.Core/bin/Release/net8.0/publish/wwwroot/Posts

chmod -R 777 /var/www/MiniBlog.Core/src/Miniblog.Core/bin/Release/net8.0/publish/wwwroot/Posts




~~~

