using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThisFuckingMusickPlayal.Models
{
    public class Song
    {
        private int id;
        private string name;
        private string author;
        private string image;
        private bool playing;

        public Song()
        {
        }

        public Song(int id, string name, string author, string image, bool playing)
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.image = image;
            this.playing = playing;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public string Image { get => image; set => image = value; }
        public bool Playing { get => playing; set => playing = value; }
    }
}
