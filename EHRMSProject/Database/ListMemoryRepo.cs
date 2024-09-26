using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EHRMSProject.Entities;
using EHRMSProject.Repos;

namespace EHRMSProject.Database
{
    public class ListMemoryRepo : IRepo
    {
        private List<User> users = new List<User>();
        private static ListMemoryRepo Instance;

        private ListMemoryRepo() { }
       
        public static ListMemoryRepo GetInstance()
        {
            
            if (Instance == null)
            {
                Instance = new ListMemoryRepo();
            }
            return Instance;
        }
        public void Create(User user)
        {
            users.Add(user);
        }

        public void DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public List<User> ReadAll()
        {
            return users;
        }

        public User ReadById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, User user)
        {
            throw new NotImplementedException();
        }

        
    }
}
