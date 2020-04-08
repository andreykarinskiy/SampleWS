using Microsoft.AspNetCore.Mvc;
using Users.API.Services;

namespace Users.API.Controllers
{
    [ApiController]
    [Route("v{v:apiVersion}/[controller]")]
    public class UsersController : Controller
    {
        private readonly IUserRepository repository;

        public UsersController(IUserRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            // Получение всех пользователей из БД (пока что не разбитых на страницы).
            var allUsers = repository.GetAll();
            
            // Возвращение JSON с пользователями и код 200.
            return Ok(allUsers);
        }
    }
}
