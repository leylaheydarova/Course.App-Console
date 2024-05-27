using Cource.Core.Models;
using Cource.Data.Repositories.Implements;
using Cource.Data.Repositories.Interfaces;
using Cource.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cource.Service.Services.Implements
{
    public class SubjectsService : ISubjectsService
    {
        private readonly ISubjectRepository _subjectRepository;
        public SubjectsService()
        {
            _subjectRepository = new SubjectRepository();
        }
        public void Add()
        {
            Subjects subject = new Subjects();
            Console.WriteLine("Subject name:");
            subject.Name = Console.ReadLine();
            subject.Createdat = DateTime.Now;
            _subjectRepository.Add(subject);
        }

        public void Delete()
        {
            Console.WriteLine("Subject ID");
            int.TryParse(Console.ReadLine(), out int id);
            if (id != null) _subjectRepository.Delete(id);
        }

        public void GetAll()
        {
            ICollection<Subjects> subjects = _subjectRepository.GetAll();
            foreach(Subjects subject in subjects)
            {
                Console.WriteLine(subject);
            }
        }

        public void GetByID()
        {
            Console.WriteLine("Subject ID");
            int.TryParse(Console.ReadLine(), out int id);
            Subjects subject = _subjectRepository.GetByID(id);
            if (subject != null) Console.WriteLine(subject);
        }

        public void Update()
        {
            Console.WriteLine("Subject ID");
            int.TryParse(Console.ReadLine(), out int id);
            Subjects updatedsubject = _subjectRepository.GetByID(id);
            if(updatedsubject != null)
            {
                Console.WriteLine("Set new name:");
                updatedsubject.Name = Console.ReadLine();
                updatedsubject.Updatedat = DateTime.Now;
                _subjectRepository.Update(updatedsubject);
            }
        }
    }
}
