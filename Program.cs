namespace _2A_Agenda_Victor_Fernando
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                MySimpleConnection.Services.MySimpleConnection.Init("root", "localhost", "agenda", "3306");
            }
            catch
            {
                // Stop the program
                Environment.Exit(0);
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Agenda_fm());
        }
    }
}