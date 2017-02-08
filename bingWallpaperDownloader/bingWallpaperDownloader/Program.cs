using bingWallpaperDownloader.Model;
using bingWallpaperDownloader.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace bingWallpaperDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            //下载必应壁纸到本地

            Console.WriteLine("开始下载");

            var js = new JavaScriptSerializer();

            var client = new WebClient() { Encoding = Encoding.UTF8 };

            var targetUrl = "http://www.bing.com/HPImageArchive.aspx?format=js&idx=0&n=1";

            var localUrl = AppDomain.CurrentDomain.BaseDirectory + "img\\" + DateTime.Today.ToString("yyyyMMdd") + ".jpg";

            var json = client.DownloadString(targetUrl);

            var response = js.Deserialize<BingWallpaperResponse>(json);

            var wallpaperUrl = "http://www.bing.com";

            if (response != null && response.images != null && response.images.Count > 0)
            {
                wallpaperUrl += response.images.FirstOrDefault().url;
            }

            var myDownloader = new Downloader()
            {
                TargetUrl = wallpaperUrl,
                LocalUrl = localUrl
            };

            myDownloader.DownLoad();

            Console.WriteLine("下载完毕");

            Console.ReadKey();
        }
    }

    

   
}
