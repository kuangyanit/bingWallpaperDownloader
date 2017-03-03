using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace bingWallpaperDownloader.Utils
{
    #region 下载器方法
    public class Downloader
    {

        public string TargetUrl { get; set; }

        public string LocalUrl { get; set; }


        public void DownLoad()
        {
            var client = new WebClient() { Encoding = Encoding.UTF8 };

            var originalCoverData = client.DownloadData(TargetUrl);

            System.IO.MemoryStream stream = new System.IO.MemoryStream(originalCoverData);

            System.Drawing.Image img = System.Drawing.Image.FromStream(stream);

            img.Save(LocalUrl);

        }
    }
    #endregion
}
