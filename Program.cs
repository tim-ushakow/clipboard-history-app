namespace ClipboardHistory
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            MainForm mainForm = new MainForm();
            ClipboardApplication application = new ClipboardApplication(mainForm);
            mainForm.setClipboardApplication(application);
            Application.Run(mainForm);
        }
    }
}