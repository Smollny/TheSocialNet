using System.Collections.Generic;
using TheSocialNet.Models.Users;

namespace TheSocialNet.ViewModels.Account
{
    public class UserViewModel
    {
        public User User { get; set; }
        public List<User> Friends { get; internal set; }

        public UserViewModel(User user)
        {
            User = user;
        }

    }
}
