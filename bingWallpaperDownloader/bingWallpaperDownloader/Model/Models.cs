using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bingWallpaperDownloader.Model
{

    #region 请求必应壁纸返回实体
    public class BingImages
    {
        public string startdate { get; set; }
        public string fullstartdate { get; set; }
        public string enddate { get; set; }
        public string url { get; set; }
        public string urlbase { get; set; }
        public string copyright { get; set; }
        public string copyrightlink { get; set; }
        public string quiz { get; set; }
        public bool wp { get; set; }
        public string hsh { get; set; }
        public int drk { get; set; }
        public int top { get; set; }
        public int bot { get; set; }
        public object hs { get; set; }

    }
    public class BingTooltips
    {
        public string loading { get; set; }
        public string previous { get; set; }
        public string next { get; set; }
        public string walle { get; set; }
        public string walls { get; set; }

    }
    public class BingWallpaperResponse
    {
        public List<BingImages> images { get; set; }
        public BingTooltips tooltips { get; set; }

    }
    #endregion
}
