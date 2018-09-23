using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAL_Deviation
{
    class Stats
    {
        //Fields
        Score[] _scores = new Score[10];
        Double _mean = 0;
        Double _deviation = 0.0;
        Int32 _totalVotes = 0;

        //Constructors
        public Stats()
        {
            for(Int32 i=0; i<10; i++)
            {
                _scores[i] = new Score(0.0, 0);
            }
        }
        public Stats(Score[] scores)
        {
            this._scores = scores;
        }

        //Properties
        public Double Mean
        {
            get
            {
                return _mean;
            }
        }
        public Double Deveation
        {
            get
            {
                return _deviation;
            }
        }
        public Int32 TotalVotes
        {
            get
            {
                return _totalVotes;
            }
        }
        public Score[] Scores
        {
            get
            {
                return _scores;
            }
            set
            {
                _scores = value;
            }
        }


        //Methods update() and get...() could be omitted, if the calculation is
        //included in the get part of the properties

        //Methods
        public void update()
        {
            getTotalVotes();
            getMean();
            getDeviation();
            
        }

        private void getMean()
        {
            _mean = 0;
            for (Int32 i = 0; i < 10; i++)
            {
                _mean += _scores[i].Percent/100 * (10 - i);
            }
        }
        private void getDeviation()
        {
            Double variance = 0;
            for(Int32 i=0; i<10; i++)
            {
                variance += _scores[i].Percent / 100 * Math.Pow((10-i)-_mean, 2);
            }
            _deviation = Math.Sqrt(variance);
        }
        private void getTotalVotes()
        {
            _totalVotes = 0;
            for(Int32 i=0; i<10; i++)
            {
                _totalVotes += _scores[i].Votes;
            }
        }


    }
}
