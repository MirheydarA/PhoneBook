namespace PhoneBook
{
    internal static class Program
    { 
        public static MainForm MainFormInstance { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            ApplicationConfiguration.Initialize();

            MainFormInstance = new MainForm();
            Application.Run(MainFormInstance);
        }
    }
}