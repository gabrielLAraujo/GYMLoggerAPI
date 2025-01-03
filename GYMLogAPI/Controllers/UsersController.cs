using GYMLogAPI.Entities;
using GYMLogAPI.Entities.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace GYMLogAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController
    {
        private AppDbContext _dbContext;
        public UsersController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IList<User>> Get(string? token)
        {
            IList<User> users = new List<User>();
            if (string.IsNullOrEmpty(token))
            {
                users = _dbContext.Users.ToList();
                return users;
            }
            else
            {
                users.Add(await _dbContext.Users.FindAsync(token));
                return users;
            }
        }
        public async Task<JsonResult> Created(UserDTO dto)
        {
            if (dto == null)
            {
                User user = new User(dto);
                await _dbContext.Users.AddAsync(user);
                await _dbContext.SaveChangesAsync();
                return new JsonResult(user);

            }
            else {
                return new JsonResult(new {Error = true, Message = "Could not create user" });
            }

        }
    }
}
