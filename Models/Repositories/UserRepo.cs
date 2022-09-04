using Bon_appetit.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bon_appetit.Models.Repositories
{  
    public class UserRepo:IUser
    {
        private readonly ApplicationDbContext _appContext;
        public UserRepo(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }
        public IEnumerable<User> AllUsers => _appContext.Users;
    }
}
