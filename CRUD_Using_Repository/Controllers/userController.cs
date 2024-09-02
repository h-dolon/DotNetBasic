using CRUD_Using_Repository.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Using_Repository.Controllers
{
    public class userController : Controller
    {
        private readonly iUser userRepository;

        public userController(iUser userRepository) // userRepository ta k userService hisebe chinta koro
        {
            this.userRepository = userRepository;
            
        }
        public async Task<IActionResult> GetUsersList()
        {
            var data = await userRepository.GetUsers();
            return View(data);
        }

        public async Task<IActionResult> AddUser()
        {
            return View();
        }
    }
}
