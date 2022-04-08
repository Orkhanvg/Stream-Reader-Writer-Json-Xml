using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream_Reader_Writer_Json_Xml.Models
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        

        public void ShowInfo()
        {
            Console.WriteLine($"id: {ID},name: {Name},salary: {Salary}");
        }
    }
}
