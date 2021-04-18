using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThisFuckingMusickPlayal.Models
{
    public abstract class Player
    {
        public abstract void play();
        public abstract void pause();

        public abstract void next();
        public abstract void prev();

        public abstract List<Song> search();
    }
}
