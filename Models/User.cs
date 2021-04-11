using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThisFuckingMusickPlayal.DAL;

namespace ThisFuckingMusickPlayal.Models
{
    public class User
    {
        private string username;
        private string password;
        private string name;
        private int age;
        private List<int> idPlaylist;

        public User()
        {
        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public User(string username, string password, string name, int age, List<int> idPlaylist)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.age = age;
            this.idPlaylist = idPlaylist;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public List<int> IdPlaylist { get => idPlaylist; set => idPlaylist = value; }
    }
}
