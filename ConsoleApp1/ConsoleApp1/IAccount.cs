using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IAccount
    {
        public bool PasswordChecker(string Password);
        public void Showinfo();
    }
}
