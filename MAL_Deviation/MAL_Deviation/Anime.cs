using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAL_Deviation
{
    class Anime
    {
        //Fields
        int     _id;
        string  _name;
        Stats   _stats;

        //Constructor
        public Anime(int id, string name, Stats stats)
        {
            this._id    = id;
            this._name  = name;
            this._stats = stats;
        }

        //Properties
        public int      Id { get; set; }
        public string   Name { get; set; }
        public Stats    Stats { get; set; }


    }
}
