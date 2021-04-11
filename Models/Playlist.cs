using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThisFuckingMusickPlayal.Models
{
    public class Playlist
    {
        private int id;
        private List<int> listSongId;

        public Playlist()
        {
        }

        public Playlist(int id, List<int> listSongId)
        {
            this.id = id;
            this.listSongId = listSongId;
        }

        public int Id { get => id; set => id = value; }
        public List<int> ListSongId { get => listSongId; set => listSongId = value; }
    }
}
