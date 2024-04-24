# 简介
[MusicalMoments](https://github.com/TheD0ubleC/MusicalMoments) 插件 API 使用 TCP Sockets 获取数据，因此需要发送 Get 请求。

你可以调用这些 API 来获取 MusicalMoments 的各种数据

详情示例可看 MMPluginSDKExample
# 获取输入
首先需要获取 Main 函数输入的第一个参数（API 地址），如下所示：
``` C#
static class Program
{
    public static string serverAddress;

    [STAThread]
    static void Main(string[] args)
    {
        ApplicationConfiguration.Initialize();
        if (args.Length == 0)
        {
            Application.Exit();
        }
        else
        {
            serverAddress = args[0];
        }
    }
}
```
如果获取成功，将继续执行；否则将退出。
# 调用
首先需要实例化一个 PluginSDK 对象，并使用 Main 的第一个参数来传入创建的实例化对象，如下所示：
```C#
public static PluginSDK pluginSDK;
pluginSDK = new PluginSDK(serverAddress);
```
接着尝试输出 MusicalMoments 的版本号：
```C#
static class Program
{
    public static string serverAddress;
    public static PluginSDK pluginSDK;
    [STAThread]
    static void Main(string[] args)
    {
        ApplicationConfiguration.Initialize();
        if (args.Length == 0)
        {
            Application.Exit();
        }
        else
        {
            serverAddress = args[0];
            pluginSDK = new PluginSDK(serverAddress);
            Console.WriteLine($"MM版本号:{pluginSDK.GetMMVer()}");
        }
    }
}
