using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student
    {
        public int Id { get; }

        private static int _id;

        public string Fullname { get; set; }

        private byte _point;

        public byte Point
        {
            get => _point;
            set
            {
                if (value > 0 && value <= 100)
                {
                    _point = value;
                }
            }
        }

        public Student(string fullname, byte point)
        {
            Id = ++_id;
            Fullname = fullname;
            Point = point;
        }

        public void Studentinfo()
        {
            Console.WriteLine($"Fullname:{Fullname}\nPoint:{Point}\nId:{Id}") ;
        }
    }
}
