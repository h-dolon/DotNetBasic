using CRUD_Using_Repository.Models;
using CRUD_Using_Repository.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Using_Repository.Repository.service
{
    public class UserService : iUser
    {
        private readonly ApplicationContext context;

        public UserService(ApplicationContext context) 
        {
            this.context = context;
        }
       public async Task<IEnumerable<User>> GetUsers()
        {
            var data= await context.Users.ToListAsync();
            return data;
        }
    }
}
