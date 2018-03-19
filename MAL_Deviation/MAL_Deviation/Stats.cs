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
        double _mean = 0;
        double _deveation = 0.0;
        int _totalVotes = 0;

        //Constructors
        public Stats()
        {
            for(int i=0; i<10; i++)
            {
                _scores[i] = new Score(0.0, 0);
            }
        }
        public Stats(Score[] scores)
        {
            this._scores = scores;
        }

        //Properties
        public double Mean
        {
            get
            {
                return _mean;
            }
        }
        public double Deveation
        {
            get
            {
                return _deveation;
            }
        }
        public int TotalVotes
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
            for (int i = 0; i < 10; i++)
            {
                _mean += _scores[i].Percent/100 * (10 - i);
            }
        }
        private void getDeviation()
        {
            double variance = 0;
            for(int i=0; i<10; i++)
            {
                variance += _scores[i].Percent / 100 * Math.Pow((10-i)-_mean, 2);
            }
            _deveation = Math.Sqrt(variance);
        }
        private void getTotalVotes()
        {
            _totalVotes = 0;
            for(int i=0; i<10; i++)
            {
                _totalVotes += _scores[i].Votes;
            }
        }


    }
}
