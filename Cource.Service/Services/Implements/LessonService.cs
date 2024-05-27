using Cource.Core.Models;
using Cource.Data.Repositories.Implements;
using Cource.Data.Repositories.Interfaces;
using Cource.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cource.Service.Services.Implements
{
    public class LessonService:ILessonsService
    {
        private readonly ILessonsRepository _lessonsRepository;
        private readonly ISubjectRepository _subjectRepository;
        private readonly IGroupRepository _groupRepository;
        private readonly ITeacherRepository _teacherRepository;
        public LessonService()
        {
            _lessonsRepository = new LessonsRepository();
            _subjectRepository = new SubjectRepository();
            _groupRepository = new GroupRepository();
            _teacherRepository = new TeacherRepository();
        }

        public void Add()
        {
            Lessons lesson = new Lessons();
            Console.WriteLine("Group ID:");
            int.TryParse(Console.ReadLine(), out int groupID);
            lesson.group = _groupRepository.GetByID(groupID);
            Console.WriteLine("Subject ID:");
            int.TryParse(Console.ReadLine(), out int subjectID);
            lesson.subjects = _subjectRepository.GetByID(subjectID);
            Console.WriteLine("Teacher ID:");
            int.TryParse(Console.ReadLine(), out int teacherID);
            lesson.teacher = _teacherRepository.GetByID(teacherID);
            lesson.Createdat = DateTime.Now;
            _lessonsRepository.Add(lesson);
        }

        public void Delete()
        {
            Console.WriteLine("Lesson ID:");
            int.TryParse(Console.ReadLine(), out int id);
            if (id != 0) _lessonsRepository.Delete(id);
            else Console.WriteLine("Invalid ID!");
        }

        public void GetAll()
        {
            ICollection<Lessons>lessons = _lessonsRepository.GetAll();
            foreach (Lessons lesson in lessons)
            {
                Console.WriteLine(lesson);
            }
        }

        public void GetByID()
        {
            Console.WriteLine("Lesson ID:");
            int.TryParse(Console.ReadLine(), out int id);
            Lessons lesson = _lessonsRepository.GetByID(id);
            if (lesson != null) Console.WriteLine(lesson);

        }

        public void Update()
        {
            Console.WriteLine("Lesson ID:");
            int.TryParse(Console.ReadLine(), out int id);
            Lessons lesson = _lessonsRepository.GetByID(id);
            if (lesson != null)
            {
                Console.WriteLine("Group ID:");
                int.TryParse(Console.ReadLine(), out int groupID);
                lesson.group = _groupRepository.GetByID(groupID);
                Console.WriteLine("Subject ID:");
                int.TryParse(Console.ReadLine(), out int subjectID);
                lesson.subjects = _subjectRepository.GetByID(subjectID);
                Console.WriteLine("Teacher ID:");
                int.TryParse(Console.ReadLine(), out int teacherID);
                lesson.teacher = _teacherRepository.GetByID(teacherID);
                lesson.Updatedat = DateTime.Now;
                _lessonsRepository.Update(lesson);
            }
        }
    }
}
