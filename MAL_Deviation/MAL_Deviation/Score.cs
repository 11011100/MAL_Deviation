using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAL_Deviation
{
    class Score
    {
        double _percent = 0;
        int _votes = 0;

        public Score()
        {
            this._percent = 0;
            this._votes = 0;
        }

        public Score(double percent, int votes)
        {
            this._percent = percent;
            this._votes = votes;
        }

        public double Percent
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
        public int Votes
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
