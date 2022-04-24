using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class User : IAccount
    {
        public int Id { get; }

        private static int _id; 

        public string Fullname { get; set; }

        public string Email { get; set; }

        public string Password { get; }

        public User(string fullname,string email)
        {
            Id = ++_id;
            Fullname = fullname;
            Email = email;
        }
        public bool PasswordChecker(string Password)
        {
            bool HassUpper = false;
            bool HasLower = false;
            bool HasDigit = false;
            if (Password.Length > 8)
            {
                foreach (var item in Password)
                {
                    if (char.IsUpper(item))
                    {
                        HassUpper = true;
                        continue;
                    }
                    if (char.IsLower(item))
                    {
                        HasLower = true;
                        continue;
                    }
                    if (char.IsDigit(item))
                    {
                        HasDigit = true;

                    }
                    bool resault = HasDigit && HasLower && HassUpper;
                    return resault;
                }
            }
            return false;
        }

        public void Showinfo()
        {
            Console.WriteLine($"Fullname:{Fullname}\nEmail:{Email}\nId:{Id}");
        }
    }
}
