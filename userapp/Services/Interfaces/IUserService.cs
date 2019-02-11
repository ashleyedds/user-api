using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserApp.Models;

namespace UserApp.Services.Interfaces
{
    public interface IUserService
    {
        Task<ActionResult<List<User>>> GetAll();
        Task<ActionResult<User>> GetById(int userId);
        Task<ActionResult<User>> PostUser(User user);
        Task<ActionResult<User>> DeleteUser(User user);
    }
}
