using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PractWork3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static readonly List<User> users = new()
        {
            new User{ Id = 1, Name = "Cava", idRole = 1 },
            new User{ Id = 2, Name = "Roman", idRole = 2 },
            new User{ Id = 3, Name = "Ivan", idRole = 1 },
        };

        private static readonly List<Role> roles = new()
        {
            new Role{ Id = 1, Name = "administration" },
            new Role{ Id = 2, Name = "user" },
        };

        [HttpGet(Name = "GetUsers")]
        public IEnumerable<User> Get()
        {
            return users.ToArray();
        }

        [HttpGet(Name = $"GetUserId")]
        public IEnumerable<User> GetId(int id)
        {
            return users.Where(u => u.Id == id).ToArray();
        }

        [HttpGet(Name = "CreateUsers")]
        public IEnumerable<User> CreateUser(string name, int idRole)
        {
            users.Add(new User
            {
                Id = users.LastOrDefault().Id + 1,
                Name = name,
                idRole = idRole
            });
            return users.ToArray();
        }

        [HttpGet(Name = "ReadUsers")]
        public IEnumerable<User> ReadUser(string name, int idRole)
        {
            return Enumerable.Range(1, 5).Select(index => new User
            {

            })
            .ToArray();
        }

        [HttpGet(Name = "UpdateUsers")]
        public IEnumerable<User> UpdateUser(int id, string name, int idRole)
        {
            return Enumerable.Range(1, 5).Select(index => new User
            {

            })
            .ToArray();
            //var user = users.Where(u => u.Id == id).ToList();
            //return users
            //{

            //})
            //.ToArray();
        }

        [HttpGet(Name = "DeleteUsers")]
        public IEnumerable<User> DeleteUser(int id)
        {
            return users.Where(u => u.Id == id).ToArray();
        }
    }
}
