using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Human
    {
        public string Name;
        public string Surname;
        //public byte? Age;
        public byte Age;

        public string GetFullname()
        {
            return Name + " " + Surname;
        }
    }
}
