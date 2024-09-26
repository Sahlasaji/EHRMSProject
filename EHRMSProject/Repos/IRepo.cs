using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EHRMSProject.Entities;

namespace EHRMSProject.Repos
{
    internal interface IRepo
    {
        void Create(User user);
        List<User> ReadAll();
        User ReadById(string id);
        void Update(string id, User user);
        void DeleteById(string id);
    }
}
