﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_05072020
{
    public class Student
    {
        private string name;
        private double grade;

        public Student(string name, double grade)
        {
            this.Name = name;
            this.Grade = grade;
        }
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public double Grade
        {
            get { return grade; }
            private set { grade = value; }
        }
        public override string ToString()
        {
            return $"Student {this.Name} has {this.Grade:f2}.";
        }
    }
}
