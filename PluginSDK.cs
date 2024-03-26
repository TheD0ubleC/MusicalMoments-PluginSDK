using System;
using System.IO;
using System.Net;

public class PluginSDK
{
    private string _serverAddress;
    // 构造函数，接受服务器地址作为参数
    public PluginSDK(string serverAddress)
    {
        _serverAddress = serverAddress;
    }
    // 获取插件版本
    public string GetPluginVer()
    {
        return Get("api/SDKVer");
    }
    // 获取播放状态
    public bool GetPlaying()
    {
        return bool.Parse(Get("api/isPlaying"));
    }
    // 获取播放音频状态
    public bool GetPlayAudio()
    {
        return bool.Parse(Get("api/playAudio"));
    }
    // 获取MM版本
    public string GetMMVer()
    {
        return Get("api/nowVer");
    }
    // 获取MM运行目录
    public string GetMMRunning()
    {
        return Get("api/runningDirectory");
    }
    // 获取播放音频键
    public string GetPlayAudioKey()
    {
        return Get("api/playAudioKey");
    }
    // 获取切换流键
    public string GetToggleStreamKey()
    {
        return Get("api/toggleStreamKey");
    }
    public int GetVBVolume()
    {
        int volume;
        if (int.TryParse(Get("api/VBvolume"), out volume))
        {
            return volume;
        }
        else
        {
            return 0;
        }
    }
    public int GetVolume()
    {
        int volume;
        if (int.TryParse(Get("api/volume"), out volume))
        {
            return volume;
        }
        else
        {
            return 0;
        }
    }
    public int GetTipsVolume()
    {
        int volume;
        if (int.TryParse(Get("api/tipsvolume"), out volume))
        {
            return volume;
        }
        else
        {
            return 0;
        }
    }
    private string Get(string relativeUrl)
    {
        string url = _serverAddress + relativeUrl;
        string result = "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
        Stream stream = resp.GetResponseStream();
        try
        {
            using (StreamReader reader = new StreamReader(stream))
            {
                result = reader.ReadToEnd();
            }
        }
        finally
        {
            stream.Close();
        }
        return result;
    }
}
