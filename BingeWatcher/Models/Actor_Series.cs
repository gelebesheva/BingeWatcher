using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BingeWatcher.Models
{
    public class Actor_Series
    {
        public int SeriesId { get; set; }
        public Series Series { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
