# bingWallpaperDownloader

## 1.写在前面

此库用于下载必应每日壁纸。

## 2.实现逻辑

1.请求 http://www.bing.com/HPImageArchive.aspx?format=js&idx=0&n=1 获取壁纸信息

2.请求结果如下：

````json
{
    "images": [
        {
            "startdate": "20171116",
            "fullstartdate": "201711161600",
            "enddate": "20171117",
            "url": "/az/hprichbg/rb/RoyalAlcazars_ZH-CN12033879324_1920x1080.jpg",
            "urlbase": "/az/hprichbg/rb/RoyalAlcazars_ZH-CN12033879324",
            "copyright": "塞维利亚王宫的大使厅，西班牙 (© Lucas Vallecillos/age fotostock)",
            "copyrightlink": "http://www.bing.com/search?q=%E5%A1%9E%E7%BB%B4%E5%88%A9%E4%BA%9A%E7%8E%8B%E5%AE%AB&form=hpcapt&mkt=zh-cn",
            "quiz": "/search?q=Bing+homepage+quiz&filters=WQOskey:%22HPQuiz_20171116_RoyalAlcazars%22&FORM=HPQUIZ",
            "wp": true,
            "hsh": "c48e5e2c2b686bea2fb7c315610e4bda",
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
````

3.壁纸地址即为：

https://www.bing.com/az/hprichbg/rb/RoyalAlcazars_ZH-CN12033879324_1920x1080.jpg

4.通过壁纸地址下载该壁纸

