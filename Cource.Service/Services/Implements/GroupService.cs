using Cource.Core.Models;
using Cource.Data.Repositories.Implements;
using Cource.Data.Repositories.Interfaces;
using Cource.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cource.Service.Services.Implements
{
    public class GroupService : IGroupService
    {
        private readonly IGroupRepository _groupRepository;
        public GroupService()
        {
            _groupRepository = new GroupRepository();
        }
        public void Add()
        {
            Group group = new Group();
            Console.WriteLine("Group Label:");
            group.Label = Console.ReadLine();
            Console.WriteLine("Description:");
            group.Description = Console.ReadLine();
            group.Createdat = DateTime.Now;
            _groupRepository.Add(group);
        }

        public void Delete()
        {
            Console.WriteLine("Group ID:");
            int.TryParse(Console.ReadLine(), out int id);
            if (id != null) _groupRepository.Delete(id);
        }

        public void GetAll()
        {
            ICollection<Group> groups = _groupRepository.GetAll();
            foreach (Group group in groups) {
                Console.WriteLine(group);
            }
        }

        public void GetByID()
        {
            Console.WriteLine("Group ID:");
            int.TryParse(Console.ReadLine(), out int id);
            Group group = _groupRepository.GetByID(id);
            if (group != null) Console.WriteLine(group);
        }

        public void Update()
        {
            Console.WriteLine("Group ID:");
            int.TryParse(Console.ReadLine(), out int id);
            Group updatedgroup = _groupRepository.GetByID(id);
            if (updatedgroup != null)
            {
                Console.WriteLine("Set new Label");
                updatedgroup.Label = Console.ReadLine();
                Console.WriteLine("Description:");
                updatedgroup.Description = Console.ReadLine();
                updatedgroup.Updatedat = DateTime.Now;
                _groupRepository.Update(updatedgroup);
            }
        }
    }
}
