using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifr
{
    public class User
    {
        private string login;
        private string password;

        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public string Login { get => login; }
        public string Password { get => password; }

        public bool IsCorrect()
        {
            Database database = new Database("Data Source=dataBase.db;Version=3;");

            if (database.CheckUser(this))
                return true;

            return false;
        }

        public bool CorrectUser()
        {
            if ((String.IsNullOrEmpty(login)) && (String.IsNullOrEmpty(password)))
                throw new Exception("Заполните пустые поля");
            if ((String.IsNullOrEmpty(login)) || (String.IsNullOrEmpty(password)))
                throw new Exception("Оставлены пустые поля");
            return true;

        }
    }
}
