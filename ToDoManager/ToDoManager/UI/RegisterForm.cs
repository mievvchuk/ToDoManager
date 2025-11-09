using System;
using System.Windows.Forms;
using System.Xml.Linq;
using ToDoManager.Core;

namespace ToDoManager.UI
{
    public partial class RegisterForm : Form
    {
        private readonly UserService _userService;

        public RegisterForm(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool result = _userService.Register(textBox1.Text, textBox2.Text);

            if (result)
            {
                MessageBox.Show("Реєстрація успішна!", "Успіх");
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Користувач уже існує!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}