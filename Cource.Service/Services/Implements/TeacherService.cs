using Cource.Core.Models;
using Cource.Data.Repositories.Implements;
using Cource.Data.Repositories.Interfaces;
using Cource.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cource.Service.Services.Implements
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherService()
        {
            _teacherRepository = new TeacherRepository();
        }
        public void Add()
        {
            Teacher teacher = new Teacher();
            Console.WriteLine("Fin seqeuence:");
            teacher.Fin = Console.ReadLine();
            Console.WriteLine("Name and Surname:");
            teacher.FullName = Console.ReadLine();
            Console.WriteLine("Email:");
            teacher.Email = Console.ReadLine();
            Console.WriteLine("Phone number: (ex, +994 XX XXX XX XX");
            teacher.PhoneNumber = Console.ReadLine();
            teacher.Createdat = DateTime.Now;
            _teacherRepository.Add(teacher);

        }

        public void Delete()
        {
            Console.WriteLine("Enter teacher's ID:");
            int.TryParse(Console.ReadLine(), out int id);
            if (id != null)
            {
                _teacherRepository.Delete(id);
            }
        }

        public void GetAll()
        {
            ICollection<Teacher>teachers = _teacherRepository.GetAll();
            foreach(Teacher teacher in teachers)
            {
                Console.WriteLine(teacher);
            }
        }

        public void GetByID()
        {
            Console.WriteLine("Enter teacher's ID:");
            int.TryParse(Console.ReadLine(), out int id);
            Teacher teacher = _teacherRepository.GetByID(id);
            if (teacher != null) Console.WriteLine(teacher);
        }

        public void Update()
        {
            Console.WriteLine("Enter teacher's ID:");
            int.TryParse(Console.ReadLine(), out int id);
            Teacher updatedteacher = _teacherRepository.GetByID(id);
            if (updatedteacher != null)
            {
                Console.WriteLine("New Fin seqeuence:");
                updatedteacher.Fin = Console.ReadLine();
                Console.WriteLine("Name and Surname:");
                updatedteacher.FullName = Console.ReadLine();
                Console.WriteLine("Email:");
                updatedteacher.Email = Console.ReadLine();
                Console.WriteLine("Phone number: (ex, +994 XX XXX XX XX");
                updatedteacher.PhoneNumber = Console.ReadLine();
                updatedteacher.Updatedat = DateTime.Now;
                _teacherRepository.Update(updatedteacher);
            }
        }
    }
}
