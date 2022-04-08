using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream_Reader_Writer_Json_Xml.Models
{
    class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        List<Employee> Employeeslist = new List<Employee>();


        public void addEmployee(Employee employee)
        {
            Employeeslist.Add(employee);
        }

        public void getEmployeeById(int?id)
        {
            if (ID==null)
            {
                throw new Exception("not found");
            }
            else
            {
                Employeeslist.FindAll(x => x.ID == id);
            }
        }

        public void RemoveEmployee(int? id)
        {
            foreach (var item in Employeeslist)
            {
                if (id==item.ID)
                {
                    Employeeslist.RemoveAt(item.ID);
                
            }

        }

    }
}
