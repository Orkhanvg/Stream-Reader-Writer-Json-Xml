using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream_Reader_Writer_Json_Xml.Models
{
    class Employee
    {
        private static int _id;
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            _id++;
            ID = _id;
            Name = name;
            Salary = salary;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"id: {ID},name: {Name},salary: {Salary}");
        }
    }
}
