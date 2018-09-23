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
        Int32   _id;
        String  _name;
        Stats   _stats;

        //Constructor
        public Anime(Int32 id, String name, Stats stats)
        {
            this._id    = id;
            this._name  = name;
            this._stats = stats;
        }

        //Properties
        public Int32      Id { get; set; }
        public String   Name { get; set; }
        public Stats    Stats { get; set; }


    }
}
