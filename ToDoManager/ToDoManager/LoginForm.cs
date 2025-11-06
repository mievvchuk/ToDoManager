using System;
using System.Windows.Forms;
using ToDoManager.Core;

namespace ToDoManager.UI
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;

        public LoginForm(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _userService.Login(txtName.Text, txtPassword.Text);

            if (user != null)
            {
                MessageBox.Show($"Вітаю, {user.Name}!", "Успішний вхід");
                MainForm main = new MainForm(new TaskService());
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильний логін або пароль!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm(_userService);
            register.Show();
        }
    }
}