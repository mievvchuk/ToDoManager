using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            bool result = _userService.Register(txtName.Text, txtPassword.Text);

            if (result)
            {
                MessageBox.Show("Реєстрація успішна!", "Успіх");
                this.Close(); // повертаємось на LoginForm
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

