using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoManager.Core
{
    [Serializable]
    public class User
    {
        public int Id { get; set; }             // Унікальний ідентифікатор користувача
        public string Name { get; set; }        // Ім’я користувача
        public string PasswordHash { get; set; } // Хеш паролю користувача

        public User() { }

        public User(int id, string name, string passwordHash)
        {
            Id = id;
            Name = name;
            PasswordHash = passwordHash;
        }

        public override string ToString()
        {
            return $"{Id}: {Name}";
        }
    }
}

