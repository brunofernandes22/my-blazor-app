using BlazorApp.DAL.Models;

namespace BlazorApp.DAL.Data
{
    public static class UserData
    {
        public static List<User> Users = new List<User>();

        public static List<User> GetAllUsers() {
            return Users;
        }

        public static User GetUser(Guid id)
        {
            var user = Users.Find(u => u.Id == id);
            if (user == null)
            {
                throw new Exception("User not found");
            }
            return user;
        }
        public static void SaveUser(User user)
        {
            var idx = Users.FindIndex(u => u.Id == user.Id);
            if (idx == -1)
                Users.Add(user);
            else
                Users[idx] = user;
        }

        public static void DeleteUser(Guid id)
        {
            var idx = Users.FindIndex(u => u.Id == id);
            if (idx != -1)
                Users.RemoveAt(idx);
            else throw new Exception("User could not be removed");
        }

    }
}
