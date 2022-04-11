using Stream_Reader_Writer_Json_Xml.Models;
using System;

namespace Stream_Reader_Writer_Json_Xml
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add employee: ");
            Console.WriteLine(" Get employee by ID: ");
            Console.WriteLine(" Remove employee: ");
            Console.WriteLine("0.Exit");
            Department departament = new Department();

            int num = int.Parse(Console.ReadLine());

            switch (num)
            {

//                1 - ci əməliyyatda istifadəçidən employee - nin bütün məlumatları istənəcək yeni bir employee
//obyekti yaranacaq və add methodu vasitəsilə listə əlavə oluncaq daha sonra həmin listi
//json - a serialize edəcəksiniz və həmin serialize olunmuş obyekti database.json faylına əlavə
//edəcəksiniz.
                case 1:
                    Employee employee = new Employee("Orkhan",50.000);
                    departament.addEmployee(employee);
                    break;

//                    2 - ci əməliyyatda istidaçi bir id daxil edəcək daha sonra database.json faylının oxuyacaqsız
//      axıra qədər ordan gələn string-i deserialize edəcəksizin department obyektinə və GetEmployeeById
//methodu vasitəsilə həmin id-li employee obyektini tapacaqsız


                case 2:
                    departament.getEmployeeById(1);
                    break;
                case 3:
                    break;
                case 0:
                    break;
            }


            string path2 = @"C:\Users\ORKHAN\Desktop\Stream - Reader - Writer - Json - Xml\Stream - Reader - Writer - Json - Xml\Files\Database.json";
        }
    }
}
