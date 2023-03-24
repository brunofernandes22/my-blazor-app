using BlazorApp.DAL.Data;
using BlazorApp.DAL.Models;

namespace BlazorApp.BLL
{
    public class UserService
    {
        public void CreateUser(User user)
        {
            user.Id = Guid.NewGuid();
            UserData.SaveUser(user);
        }
        
        public List<User> GetAllUsers()
        {
           return UserData.GetAllUsers();
        }
        public User GetUser(Guid id)
        {
            return UserData.GetUser(id);
        }
        public void UpdateUser(User user)
        {
            UserData.SaveUser(user);
        }
        public void DeleteUser(Guid id) {
            UserData.DeleteUser(id);
        }
    }
}