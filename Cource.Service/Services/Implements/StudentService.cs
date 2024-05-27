using Cource.Core.Models;
using Cource.Data.Repositories.Implements;
using Cource.Data.Repositories.Interfaces;
using Cource.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cource.Service.Services.Implements
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IGroupRepository _groupRepository;
        public StudentService()
        {
            _studentRepository = new StudentRepository();
            _groupRepository = new GroupRepository();
        }
        public void Add()
        {
            Student student = new Student();
            Console.WriteLine("Fin seqeuence:");
            student.Fin = Console.ReadLine();
            Console.WriteLine("Name and Surname:");
            student.FullName = Console.ReadLine();
            Console.WriteLine("Email:");
            student.Email = Console.ReadLine();
            Console.WriteLine("Phone number: (ex, +994 XX XXX XX XX");
            student.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Group ID:");
            int.TryParse(Console.ReadLine(), out int groupid);
            Group group = _groupRepository.GetByID(groupid);
            if (group == null) Console.WriteLine("Invalid ID!");
            student.Createdat = DateTime.Now;
            _studentRepository.Add(student);
        }


        public void Delete()
        {
            Console.WriteLine("Enter student's ID:");
            int.TryParse(Console.ReadLine(), out int id);
            if (id != null)
            {
                _studentRepository.Delete(id);
            }
        }

        public void GetAll()
        {
            ICollection<Student> students = _studentRepository.GetAll();
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }

        public void GetByID()
        {
            Console.WriteLine("Enter student's ID:");
            int.TryParse(Console.ReadLine(), out int id);
            Student student = _studentRepository.GetByID(id);
            if (student != null) Console.WriteLine(student);
        }

        public void Update()
        {
            Console.WriteLine("Enter teacher's ID:");
            int.TryParse(Console.ReadLine(), out int id);
            Student updatedstudent = _studentRepository.GetByID(id);
            if (updatedstudent != null)
            {
                Console.WriteLine("New Fin seqeuence:");
                updatedstudent.Fin = Console.ReadLine();
                Console.WriteLine("Name and Surname:");
                updatedstudent.FullName = Console.ReadLine();
                Console.WriteLine("Email:");
                updatedstudent.Email = Console.ReadLine();
                Console.WriteLine("Phone number: (ex, +994 XX XXX XX XX");
                updatedstudent.PhoneNumber = Console.ReadLine();
                Console.WriteLine("Group ID:");
                int.TryParse(Console.ReadLine(), out int groupid);
                Group group = _groupRepository.GetByID(groupid);
                if (groupid == null) Console.WriteLine("Invalid ID!");
                updatedstudent.Updatedat = DateTime.Now;
                _studentRepository.Update(updatedstudent);
            }
        }
    }
}
