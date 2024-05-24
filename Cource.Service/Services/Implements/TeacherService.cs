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
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetByID()
        {
            Console.WriteLine("Teacher ID:");
            int.TryParse(Console.ReadLine(), out int id);
            Teacher teacher = _teacherRepository.GetByID(id);
            if (id != null) {
                _teacherRepository.GetByID(teacher);
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
