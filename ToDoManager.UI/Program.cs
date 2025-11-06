using ToDoManager.UI;

namespace ToDoManager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var userService = new UserService();
            Application.Run(new LoginForm(userService));
        }
    }
}
