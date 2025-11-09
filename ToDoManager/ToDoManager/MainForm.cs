using System;
using System.Linq;
using System.Windows.Forms;
using ToDoManager.Core;
using ToDoManager.UI;

namespace ToDoManager
{
    public partial class MainForm : Form
    {
        private enum FilterType { All, Completed, Active }
        private FilterType _currentFilter = FilterType.All;
        private readonly TaskService _taskService;

        public MainForm(TaskService taskService)
        {
            InitializeComponent();
            _taskService = taskService;
            radioButton1.Checked = true; // стандартно показує всі задачі
            RefreshGrid();
        }

        // 🟢 Оновлення DataGridView
        // 🟢 Оновлення DataGridView
        private void RefreshGrid()
        {
            var tasks = _taskService.GetAll();

            switch (_currentFilter)
            {
                case FilterType.Completed:
                    tasks = tasks.Where(t => t.IsCompleted);
                    break;
                case FilterType.Active:
                    tasks = tasks.Where(t => !t.IsCompleted);
                    break;
                case FilterType.All:
                default:
                    break;
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tasks.ToList();

            // 🟢 Ховаємо Id, задаємо заголовки
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["CreatedAt"].HeaderText = "Створено";
            dataGridView1.Columns["IsCompleted"].HeaderText = "Виконано";

            // 💡 Додаємо це ↓
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Щоб текст був по центру (опціонально)
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }



        // 🟢 Додати задачу
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTaskForm addForm = new AddTaskForm(_taskService);

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        // 🟡 Редагувати задачу
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Оберіть задачу для редагування!", "Увага");
                return;
            }

            // 🟢 отримуємо вибрану задачу
            var task = (TaskItem)dataGridView1.CurrentRow.DataBoundItem;

            // 🟡 відкриваємо форму редагування
            EditTaskForm editForm = new EditTaskForm(_taskService, task);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid(); // оновлюємо таблицю після збереження
            }
        }

        // 🔴 Видалити задачу
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Оберіть задачу для видалення!");
                return;
            }

            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            _taskService.Delete(id);
            RefreshGrid();
        }


        // 🟢 При виборі рядка заповнюємо поля для редагування

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                if (radioButton1.Checked)
                {
                    _currentFilter = FilterType.All;
                    RefreshGrid();
                }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                _currentFilter = FilterType.Completed;
                RefreshGrid();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                _currentFilter = FilterType.Active;
                RefreshGrid();
            }
        }
    }
}