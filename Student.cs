using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Models
{
    class Student
    {
        public string FullName;
        public string GroupNo;
        public bool Type;
        public Student(string fullName, string groupNo,bool type)
        {
            FullName = fullName;
            GroupNo = groupNo;
            Type = type;
        }
        public override string ToString()
        {
            var result = Type ? "Zemanetli" : "Zemanetsiz";
            return $"Fullname:{FullName} Group No:{GroupNo} Type:{result}";
        }
    }
}
