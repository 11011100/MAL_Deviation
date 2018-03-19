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
        public Form1()
        {
            InitializeComponent();
        }

        

        private void buttonSavePath_Click(object sender, EventArgs e)
        {
            
            
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
    }
}
