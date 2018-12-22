using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAL_Deviation
{
    public partial class Form1 : Form
    {
        //Type definition
        public enum Status { Stopped, Running, Paused };

        //Fields
        String      _folderPath;
        List<Anime> _animeList = new List<Anime>();
        Int32       _currentIndex = 0;
        Status      _currentStatus;

        //Properties
        public Status CurrentStatus
        {
            get { return _currentStatus; }
            set
            {
                _currentStatus = value;
                OnStatusChanged();          //Despite its name this is not implemented as an event
            }
        }


        //Constructor
        public Form1()
        {
            InitializeComponent();
        }

        //Custom Event, to executed when the Status changes (e.g. Stopp -> Running)
        //public event System.EventHandler StatusChanged;
        protected virtual void OnStatusChanged()
        {
            switch (CurrentStatus)
            {
                case Status.Stopped:
                    stop();                    
                    break;
                case Status.Running:
                    run();
                    break;
                case Status.Paused:
                    pause();
                    break;
            }
        }

        private void buttonSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                _folderPath = folderBrowserDialog.SelectedPath;
                textBoxSavePath.Text = _folderPath;
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            //Testing mean and deviation calculation
            
            Score[] scores = new Score[10]
            {
                new Score(6.25, 1),
                new Score(6.25, 1),
                new Score(12.5, 2),
                new Score(18.75, 3),
                new Score(6.25, 1),
                new Score(18.75, 3),
                new Score(12.5, 2),
                new Score(6.25, 1),
                new Score(6.25, 1),
                new Score(6.25, 1)
            };
            Stats stats = new Stats(scores);
            stats.update();
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (_folderPath != null)
            {
                if (numericUpDownStartIndex.Value <= numericUpDownStopIndex.Value)
                {
                    if (CurrentStatus == Status.Stopped || CurrentStatus == Status.Paused)
                        { CurrentStatus = Status.Running; }
                    else
                        { CurrentStatus = Status.Paused; }
                }
                else
                    { MessageBox.Show("Stop index must be bigger or equal to start index."); }
            }
            else
                { MessageBox.Show("Enter a save location for the ouput file."); }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (CurrentStatus == Status.Running || CurrentStatus == Status.Paused)
                { CurrentStatus = Status.Stopped; }
        }

        /*
         *Think about renaming methods to changeGUI(Status stauts){...} 
         * */

        private void run()
        {
            labelStatusCurrent.Text = "Running";
            buttonStart.Text = "Pause";

            //Why here?
            //progressBar1.Value = _currentIndex*100 / (int) (numericUpDownStopIndex.Value + numericUpDownStartIndex.Value);

        }

        private void stop()
        {
            labelStatusCurrent.Text = "Stopped";
            buttonStart.Text = "Start";

            _currentIndex = 0;
        }

        private void pause()
        {
            labelStatusCurrent.Text = "Paused";
            buttonStart.Text = "Start";
        }



    }
}
