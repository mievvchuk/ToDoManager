using System.Collections.Generic;
using System.Linq;

namespace ToDoManager.Core
{
    public class TaskService
    {
        private readonly List<TaskItem> _tasks = new List<TaskItem>();
        private int _nextId = 1;

        public TaskItem Create(string title, string description)
        {
            var t = new TaskItem();
            t.Id = _nextId++;
            t.Title = title;
            t.Description = description;
            t.IsCompleted = false;
            _tasks.Add(t);
            return t;
        }

        public IEnumerable<TaskItem> GetAll() { return _tasks; }

        public bool Update(TaskItem updated)
        {
            var existing = _tasks.FirstOrDefault(x => x.Id == updated.Id);
            if (existing == null) return false;
            existing.Title = updated.Title;
            existing.Description = updated.Description;
            existing.IsCompleted = updated.IsCompleted;
            return true;
        }

        public bool Delete(int id)
        {
            var t = _tasks.FirstOrDefault(x => x.Id == id);
            if (t == null) return false;
            _tasks.Remove(t);
            return true;
        }
    }
}
