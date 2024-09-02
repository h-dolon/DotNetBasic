using CRUD_Using_Repository.Models;

namespace CRUD_Using_Repository.Repository.Interface
{
    public interface iUser
    {
        Task<IEnumerable<User>> GetUsers();
    }
}
