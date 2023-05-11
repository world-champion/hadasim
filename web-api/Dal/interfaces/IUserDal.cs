using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dal. interfaces
{
    public interface IUserDal
{
        User addUser(User user);

        List<User> getAllUser();

        Object findUser(int id);
    }
}
