using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_task
{
    public class User
    {
        private string userName;
        private string password;

        public User(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName))
            {
                throw new ArgumentException("Ad bosh qala bilmez.");
            }

            if (userName.Length < 6 || userName.Length > 25)
            {
                throw new ArgumentException("Ad minimum 25 simvol olmalidir.");
            }

            if (password.Length < 8 || password.Length > 25)
            {
                throw new ArgumentException("Parol 8 simvoldan 25 e qeder olmalidir.");
            }

            if (!HasUpper(password) || !HasLower(password) || !HasDigit(password))
            {
                throw new ArgumentException("Parolda ən azı bir böyük hərf, bir kiçik hərf və bir rəqəm olmalıdır.");
            }

            this.userName = userName;
            this.password = password;
        }

        public string UserName
        {
            get { return this.userName; }
        }

        public string Password
        {
            get { return this.password; }
        }

        public bool HasDigit(string value)
        {
            return value.Any(c => Char.IsDigit(c));
        }

        public bool HasUpper(string value)
        {
            return value.Any(c => Char.IsUpper(c));
        }

        public bool HasLower(string value)
        {
            return value.Any(c => Char.IsLower(c));
        }
    }

}
