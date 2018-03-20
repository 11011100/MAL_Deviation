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
        //Fields
        string folderPath;
        List<Anime> animeList = new List<Anime>();
        int currentIndex = 0;
        enum Status { Stopped, Running, Paused };
        Status currentStatus;

        //Constructor
        public Form1()
        {
            InitializeComponent();
        }

        

        private void buttonSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog.SelectedPath;
                textBoxSavePath.Text = folderPath;
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
            if(folderPath != null)
            {
                if(numericUpDownStartIndex.Value <= numericUpDownStopIndex.Value)
                {
                    if(currentStatus == Status.Stopped || currentStatus == Status.Paused)
                    {
                        currentStatus = Status.Running;
                        labelStatusCurrent.Text = "Running";
                        buttonStart.Text = "Pause";
                    }
                    else
                    {
                        currentStatus = Status.Paused;
                        labelStatusCurrent.Text = "Paused";
                        buttonStart.Text = "Start";
                    }
                    
                }
                else
                {
                    MessageBox.Show("Stop index must be bigger or equal to start index.");
                }
            }
            else
            {
                MessageBox.Show("Enter a save location for the ouput file.");
            }
        }
    }
}
