using System;
using System.Windows.Forms;
using ToDoManager.Core;

namespace ToDoManager.UI
{
    public partial class AddTaskForm : Form
    {
        private readonly TaskService _taskService;

        public AddTaskForm(TaskService taskService)
        {
            InitializeComponent();
            _taskService = taskService;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Назва задачі не може бути порожньою!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newTask = _taskService.Create(textBox1.Text, textBox2.Text);
            newTask.IsCompleted = checkBox1.Checked;

            MessageBox.Show("Задачу успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
