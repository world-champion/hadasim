using Dal.interfaces;
using Entity;

namespace Dal
{
    public class UserDal : IUserDal
    {
        ProjectContext userContext;

        public UserDal(ProjectContext userContext)
        {
            this.userContext = userContext;
        }
        public User addUser(User user)
        {
            userContext.users.Add(user);
            userContext.SaveChanges();
            return user;
        }

        public Object findUser(int id)
        {
            return userContext.users.FirstOrDefault(x => x.id == id);
        }

        public List<User> getAllUser()
        {
            return userContext.users.ToList();
        }
        
    }
}