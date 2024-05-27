using GYMLogAPI.Entities.DTOs;

namespace GYMLogAPI.Entities
{
    public class User
    {
        public string token {  get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User()
        {

        }
        public User(UserDTO dto) {
            token = new Guid().ToString();
            Name = dto.Name;
            Email = dto.Email;
            Password = dto.Password;
        }
    }
}
