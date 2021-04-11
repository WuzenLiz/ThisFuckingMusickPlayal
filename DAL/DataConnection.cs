using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThisFuckingMusickPlayal.Models;

namespace ThisFuckingMusickPlayal.DAL
{
    public class DataConnection
    {
        private const string connectionString = @"";
        
        public Song getSong(int id)
        {
            return null;
        }

        public Playlist getPlayList(int id)
        {
            return null;
        }

        public bool checkLogin(User user)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = conn.CreateCommand();

            comm.CommandText = "Execute CHECKLOGIN @username, @password";

            return false;
        }

        public void changeUserInfor()
        {

        }

        public void addSongToPlaylist(int songId, int playlistId)
        {

        }

        public void deleteSongFromPlaylist(int songId, int playlistId)
        {

        }

    }
}
