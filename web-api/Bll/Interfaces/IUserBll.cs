using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Interfaces
{
    public interface IUserBll
    {
        UserDto addUser(UserDto user);
        List<UserDto> getUsers();
    }
}
