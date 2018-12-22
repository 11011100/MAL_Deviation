using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAL_Deviation
{
    class Score
    {
        //Fields
        Double _percent = 0;
        Int32 _votes = 0;

        //Constructors
        public Score()
        {
            this._percent = 0;
            this._votes = 0;
        }

        public Score(Double percent, Int32 votes)
        {
            this._percent = percent;
            this._votes = votes;
        }


        //Properties
        public Double Percent
        {
            get
            {
                return _percent;
            }
            set
            {
                _percent = value;
            }
        }
        public Int32 Votes
        {
            get
            {
                return _votes;
            }
            set
            {
                _votes = value;
            }
        }

        
    }
}
