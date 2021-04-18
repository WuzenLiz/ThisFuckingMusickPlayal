using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThisFuckingMusickPlayal.DAL;

namespace ThisFuckingMusickPlayal.Models
{
    public class User : Player
    {
        private string username;
        private string password;
        private string name;
        private DateTime birth;
        private List<int> idPlaylist;
        public User()
        {
        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public User(string username, string password, string name, DateTime birth, List<int> idPlaylist)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.birth = birth;
            this.idPlaylist = idPlaylist;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public List<int> IdPlaylist { get => idPlaylist; set => idPlaylist = value; }

        public override void next()
        {
            throw new NotImplementedException();
        }

        public override void pause()
        {
            throw new NotImplementedException();
        }

        public override void play()
        {
            throw new NotImplementedException();
        }

        public override void prev()
        {
            throw new NotImplementedException();
        }

        public override List<Song> search()
        {
            throw new NotImplementedException();
        }

        public void addSongToPlaylist(int idSong, int idPlaylist)
        {

        }

        public void deleteSongFromPlaylist(int idSong, int idPlaylist)
        {

        }

        public void changeInfor()
        {

        }

        public User getInfor()
        {
            return null;
        }

        public List<Song> getPlaylist(int idPlaylist)
        {
            return null;
        }

        public void logout()
        {

        }
    }
}
