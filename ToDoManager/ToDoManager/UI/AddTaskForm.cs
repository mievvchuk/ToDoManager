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

            var newTask = new TaskItem
            {
                Title = textBox1.Text,
                Description = textBox2.Text,
                IsCompleted = checkBox1.Checked
            };

            _taskService.Add(newTask);

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
