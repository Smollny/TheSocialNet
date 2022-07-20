using System.Collections.Generic;
using TheSocialNet.Models.Users;

namespace TheSocialNet.ViewModels.Account
{
    public class ChatViewModel
    {
        public User You { get; set; }

        public User ToWhom { get; set; }

        public List<Message> History { get; set; }

        public MessageViewModel NewMessage { get; set; }

        public ChatViewModel()
        {
            NewMessage = new MessageViewModel();
        }
    }
}
