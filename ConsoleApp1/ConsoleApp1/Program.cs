using System;

namespace ConsoleApp1
{
    class Program
    {
        public static bool CheckGroupNo(string groupNo)
        {
            bool HasDigit = false;
            bool HasUpper = false;

            if (groupNo.Length == 5)
            {
                foreach (var item in groupNo)
                {
                    if (char.IsUpper(item))
                    {
                        HasUpper = true;
                        continue;
                    }
                    if (char.IsDigit(item))
                    {
                        HasDigit = true;
                    }
                    bool result = HasDigit && HasUpper;
                    return result;
                }
            }
            return false;
        }
        public static bool PasswordChecker(string Password)
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
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter fullname");
            string fullname = Console.ReadLine();
            Console.WriteLine("enter email");
            string email = Console.ReadLine();
            string password;
            int studentlimit;
            string groupNo;
            do
            {
                Console.WriteLine("enter password");
                password = Console.ReadLine();


            } while (!PasswordChecker(password));

           
            
            Console.WriteLine("1  Show info");            
            Console.WriteLine("2   Create new group");

            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:

                    User user = new User(fullname, email);
                    user.Showinfo();
                    break;
                case 2:
                    Console.WriteLine("");
                    do
                    {
                        Console.WriteLine("enter groupno");
                        groupNo = Console.ReadLine();
                    } while (!CheckGroupNo(groupNo));                
                    do
                    {
                        Console.WriteLine("enter studentlimit");
                        studentlimit = Convert.ToInt32(Console.ReadLine());
                    } while (studentlimit< 4 || studentlimit >=18 );
                   
                    Group group = new Group(groupNo,studentlimit);
                    
                  
                    break;
                default:
                    break;
            }
        }
    }
}
