using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ToDoManager.Core;

namespace ToDoManager.ToDoManager.Core
{
    public class UserService
    {
        private readonly List<User> _users = new List<User>();
        private int _nextId = 1;

        // 🟢 Реєстрація користувача
        public bool Register(string name, string password)
        {
            if (_users.Any(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
                return false; // користувач уже існує

            string hash = HashPassword(password);

            var newUser = new User
            {
                Id = _nextId++,
                Name = name,
                PasswordHash = hash
            };

            _users.Add(newUser);
            return true;
        }

        // 🔵 Авторизація користувача
        public User Login(string name, string password)
        {
            string hash = HashPassword(password);
            return _users.FirstOrDefault(u =>
                u.Name.Equals(name, StringComparison.OrdinalIgnoreCase) &&
                u.PasswordHash == hash);
        }

        // 🔒 Хешування паролю
        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        // ⚪ Для тестів
        public IEnumerable<User> GetAllUsers() => _users;
    }
}
