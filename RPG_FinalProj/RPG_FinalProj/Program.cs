using Trial1_Movement_Classes_COMPROGPROJ;

namespace RPG_FinalProj
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static LocItems items { get; } = new LocItems();
        public static quest1Dialogue dialogues { get; } = new quest1Dialogue();
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new charSelectForm());
        }
    }
}