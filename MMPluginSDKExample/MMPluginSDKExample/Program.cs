namespace MMPluginTest
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            if (args.Length == 0 && !System.Diagnostics.Debugger.IsAttached)
            {
                Application.Exit();
            }
            else
            {
                Application.Run(new MainForm(args.Length > 0 ? args[0] : null));
            }
        }
    }
}