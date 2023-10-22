using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4.Entities
{
    public class User
    {
        public string Username { get; set; }
        public int FollowerCount { get; set; }

        public User()
        {
            
        }
        public User(string username, int followerCount)
        {
            Username = username;
            FollowerCount = followerCount;
        }
    }
}
