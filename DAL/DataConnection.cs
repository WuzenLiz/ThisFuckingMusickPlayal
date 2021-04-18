using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = conn.CreateCommand();
            conn.Open();
            comm.CommandText = "Execute GETSONG @id";
            SqlDataReader reader = comm.ExecuteReader();


            conn.Close();
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
            conn.Open();

            comm.CommandText = "Execute CHECKLOGIN @username, @password";
            comm.Parameters.Add("@username", SqlDbType.NChar, 15).Value = user.Username;
            comm.Parameters.Add("@password", SqlDbType.NChar, 15).Value = user.Password;

            SqlDataReader reader = comm.ExecuteReader();

            while(reader.Read())
            {
                if(user.Username == reader["username"].ToString())
                {
                    if (user.Password == reader["password"].ToString()) return true;
                    return false;
                }
            }

            return false;
        }

        public void changeUserInfor(User user)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = conn.CreateCommand();

            comm.CommandText = "Execute CHANGEUSERINFOR @username, @password, @name, @birth";
            SqlDataReader reader = comm.ExecuteReader();
            List<User> l = new List<User>();
            while (reader.Read())
            {
                if (reader["Username"].ToString() == user.Username)
                {
                    reader["password"]
                }
            }
            return false;
        }

        public void addSongToPlaylist(int songId, int playlistId)
        {

        }

        public void deleteSongFromPlaylist(int songId, int playlistId)
        {

        }

    }
}
