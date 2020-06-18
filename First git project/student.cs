using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_git_project
{
    class student : person
    {
        private string m_studentID;
        public string StudentID
        {
            get // accessor
            {
                return m_studentID;
            }
            set // mutator
            {
                m_studentID = value;
            }
        }
        public student(string name, int age, string student_id)
            : base(name, age)
        {
            StudentID = student_id;
        }
        public void Studies()
        {
            Console.WriteLine($"{Name} is Studying.");
        }
        public override string ToString()
        {
            string outputString = "";

            outputString += "\n+++++++++++++++++++++++++++++++\n";
            outputString += $" Name      : {Name}         \n";
            outputString += $" Age       : {Age}          \n";
            outputString += $" StudentID : {StudentID}    \n";
            outputString += "+++++++++++++++++++++++++++++++\n";

            return outputString;
        }
    }
}
