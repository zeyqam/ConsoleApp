using ConsoleApp19.Core.Models;
using ConsoleApp19.Helpers;
using ConsoleApp19.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19.Implementations
{
    internal class StudentService : Iservice, IStudentService
    {
        private Student[] Students = { };
        public void Create()
        {
            
            Student student = new Student();
            Console.WriteLine("Name");
            string name= Console.ReadLine();
            while (!name.ChekLenght())
            {
                Console.WriteLine("Name is not alid");
                name = Console.ReadLine();
            }
            student.Name= name;
            Console.WriteLine("Surname");
            string surname = Console.ReadLine();
            while (!surname.ChekLenght())
            {
                Console.WriteLine("Surname is not valid");
                surname= Console.ReadLine();
            }
            student.Surname= surname;
            Console.WriteLine("GroupNo");
            string GroupNo = Console.ReadLine();
            while (!GroupNo.ChekLenght())
            {
                Console.WriteLine("GroupNo is not valid");
                GroupNo = Console.ReadLine();
            }
            student.GroupNo= GroupNo;
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length-1] = student;




        }

        public void Delete()
        {
            Console.WriteLine("Please addId");
            int.TryParse(Console.ReadLine(), out int id);
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == id)
                {
                    Student student = Students[Students.Length - 1];
                    Students[Students.Length - 1] = Students[i];
                    Students[i] = student;

                    Array.Resize(ref Students, Students.Length - 1);

                    return;
                }


            }
            Console.WriteLine($"Student model is {id}, -id not found");
        }

        public void GetAll()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(student);
            }
        }

        public void GetbyId()
        { 
            Console.WriteLine("Insert Student Id");
            int id;
            while(!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please insert a number");
            }
            foreach(Student student in Students)
            {
                if(student.Id == id)
                {
                    return;
                }
            }
             
        }

        public void Update()
        {
            Console.WriteLine("Please add Id");
            int.TryParse(Console.ReadLine(), out int id);
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == id)
                {
                    Students[i].Name = Console.ReadLine();

                    Students[i].Surname = Console.ReadLine();

                    Students[i].GroupNo = Console.ReadLine();

                    return;

                }


            }
            Console.WriteLine($"Student model is {id}, -id not found");

        }
       
    }

}
