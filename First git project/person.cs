using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_git_project
{
    class person
    {
        private string m_name;
        private int m_age;
        public string Name{
            get
            {return m_name;}
            set
            {m_name = value;}
        }
        public int Age
        {
            get
            {return m_age;}
            set
            {m_age = value;}
        }
        public person(string name, int age)
        {
            m_name = name;
            m_age = age;
        }
        public void SaysHello()
        {
            Console.WriteLine($"{Name} says Hello");
        }
        public override string ToString()
        {
            string outputString = "";
            outputString += "\n++++++++++++++++++++++++\n";
            outputString += $" Name: {Name}         \n";
            outputString += $" Age : {Age}          \n";
            outputString += "++++++++++++++++++++++++\n";
            return outputString;
        }
    }
}
