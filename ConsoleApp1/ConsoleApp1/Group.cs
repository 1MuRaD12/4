using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Group
    {
        public  string GroupNo { get; set; }

        private Student[] students;

        private int _studentLimit;

        public Group(string groupno,int studentlimit)
        {
            GroupNo = groupno;
            StudentLimit = studentlimit;
        }

       

        public int StudentLimit
        {
            get => _studentLimit;
            set
            {
                if (value >= 5 && value <= 18)
                {
                    _studentLimit = value;
                }
            }
        }

        public Group()
        {
            students = new Student[0];
        }

        public Student[] GetAllstudent()
        {
            return students;
        }

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

        public void AddStudent(Student student)
        {
            if (students.Length == StudentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }
        }

        public void GetStudent(int? id)
        {
            foreach (var item in students)
            {
                if (item.Id == id)
                {
                    Console.WriteLine(item);
                }

            }
        }

    }
}
