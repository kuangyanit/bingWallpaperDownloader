# bingWallpaperDownloader

## 1.写在前面

此库用于下载必应每日壁纸。

## 2.实现逻辑

1.请求 ** http://www.bing.com/HPImageArchive.aspx?format=js&idx=0&n=1 ** 获取壁纸信息

2.请求结果如下：

{
  "images": [
    {
      "startdate": "20170207",
      "fullstartdate": "201702071600",
      "enddate": "20170208",
      "url": "/az/hprichbg/rb/ItapuaLighthouse_ZH-CN10867280946_1920x1080.jpg",
      "urlbase": "/az/hprichbg/rb/ItapuaLighthouse_ZH-CN10867280946",
      "copyright": "萨尔瓦多的Itapuã 灯塔，巴西巴伊亚州 (© Uiler Costa/Offset)",
      "copyrightlink": "http://www.bing.com/search?q=Itapu%C3%A3+Lighthouse&form=hpcapt&mkt=zh-cn",
      "quiz": "/search?q=Bing+homepage+quiz&filters=WQOskey:%22HPQuiz_20170207_ItapuaLighthouse%22&FORM=HPQUIZ",
      "wp": true,
      "hsh": "d480f4646e4502a47573d74e0a5d9b7f",
      "drk": 1,
      "top": 1,
      "bot": 1,
      "hs": []
    }
  ],
  "tooltips": {
    "loading": "正在加载...",
    "previous": "上一个图像",
    "next": "下一个图像",
    "walle": "此图片不能下载用作壁纸。",
    "walls": "下载今日美图。仅限用作桌面壁纸。"
  }
}

3.壁纸地址即为：https://www.bing.com/az/hprichbg/rb/ItapuaLighthouse_ZH-CN10867280946_1920x1080.jpg
[由https://www.bing.com/与请求结果中的url拼接而成]


4.通过壁纸地址下载该壁纸

