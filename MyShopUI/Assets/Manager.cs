using UnityEngine;
using System.Collections;
using System.Text;
using System.Net;
using System;

public enum Language
{
    Auto = 0,
    ZH = 1,
    JP = 2,
    EN = 3,
    KOR = 4,
    SPA = 5,
    FRA = 6,
    TH = 7,
    ARA = 8,
    RU = 9,
    PT = 10,
    YUE = 11,
    WYW = 12,
    DE = 13,
    NL = 14,
    IT = 15,
    EL = 16
}
public class Manager : MonoBehaviour
{

    public void Start()
    {
        TranslationResult newInfo =  GetTranslationFromBaiduFanyi("bugcreater", Language.Auto, Language.ZH);
    }

    public static TranslationResult GetTranslationFromBaiduFanyi(string source, Language from = Language.Auto, Language to = Language.Auto)
    {
        string jsonResult = string.Empty;
        string apiKey = "yourApiKey";
        string url = string.Format("http://openapi.baidu.com/public/2.0/bmt/translate?client_id={0}&q={1}&from={2}&to={3}",
            apiKey,
            HttpUtility.UrlEncode(source, Encoding.UTF8),
            from.ToString().ToLower(),
            to.ToString().ToLower());
        WebClient wc = new WebClient();
        try
        {
            jsonResult = wc.DownloadString(url);
        }
        catch (Exception e)
        {
            jsonResult = string.Empty;
        }
        JavaScriptSerializer jss = new JavaScriptSerializer();
        TranslationResult ret = jss.Deserialize<TranslationResult>(jsonResult);
        return ret;
    }
}


