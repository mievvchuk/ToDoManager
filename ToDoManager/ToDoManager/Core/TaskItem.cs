using System;

namespace ToDoManager.Core
{
    [Serializable]
    public class TaskItem
    {
        public int Id { get; set; }                  // Унікальний ідентифікатор
        public string Title { get; set; }            // Назва задачі
        public string Description { get; set; }      // Опис задачі
        public bool IsCompleted { get; set; }        // Статус виконання
        public DateTime CreatedAt { get; set; }      // Дата створення

        public TaskItem()
        {
            CreatedAt = DateTime.Now;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return $"{Id}: {Title} ({(IsCompleted ? "Виконано" : "Активна")})";
        }
    }
}
