using Cource.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cource.Service.Services.Implements
{
    public class MenuService : IMenuService
    {
        public void ShowMenu()
        {
            Console.WriteLine("1.Group Menu\n2.Student Menu\n3.Teacher Menu\n4.Subjects Menu\n5.Lessons Menu\n0.Exit");
            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("Enter option:");
                int.TryParse(Console.ReadLine(), out int step);

                switch (step)
                {
                    case 0:
                        isContinue = false;
                        break;
                    case 1:
                        IGroupService groupService = new GroupService();
                        SubMenu(groupService);
                        break;
                    case 2:
                        IStudentService studentService = new StudentService();
                        SubMenu(studentService);
                        break;
                    case 3:
                        ITeacherService teacherService = new TeacherService();
                        SubMenu(teacherService);
                        break;
                    case 4:
                        ISubjectsService subjectsService = new SubjectsService();   
                        SubMenu(subjectsService);
                        break;
                    case 5:
                        ILessonsService lessonsService = new LessonService();
                        SubMenu(lessonsService);
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
        }

        public void SubMenu(IService service)
        {
            string type = service.GetType().Name.Split("Service")[0];
            Console.WriteLine(type);
            Console.WriteLine($"1.Add {type}\n2.Update {type}\n3.Remove {type}\n4.Get {type} by ID\n5.Get all {type}s\n0.Exit");
            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("Enter option:");
                int.TryParse(Console.ReadLine(), out int step);

                switch (step)
                {
                    case 0:
                        isContinue = false;
                        break;
                    case 1:
                        service.Add();
                        break;
                    case 2:
                        service.Update();
                        break;
                    case 3:
                        service.Delete();
                        break;
                    case 4:
                        service.GetByID();
                        break;
                    case 5:
                        service.GetAll();
                        break;
                    default:
                        Console.WriteLine("Invalid option!Try again.");
                        break;
                }
            }
        }
    }
}
