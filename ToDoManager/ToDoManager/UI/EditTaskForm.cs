using System;
using System.Windows.Forms;
using ToDoManager.Core;

namespace ToDoManager.UI
{
    public partial class EditTaskForm : Form
    {
        private readonly TaskService _taskService;
        private readonly TaskItem _taskToEdit;

        public EditTaskForm(TaskService taskService, TaskItem task)
        {
            InitializeComponent();
            _taskService = taskService;
            _taskToEdit = task;

            // 🟢 заповнюємо поля існуючими даними
            textBox1.Text = _taskToEdit.Title;
            textBox2.Text = _taskToEdit.Description;
            checkBox1.Checked = _taskToEdit.IsCompleted;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Назва задачі не може бути порожньою!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _taskToEdit.Title = textBox1.Text;
            _taskToEdit.Description = textBox2.Text;
            _taskToEdit.IsCompleted = checkBox1.Checked;

            _taskService.Update(_taskToEdit);

            MessageBox.Show("Задачу успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}