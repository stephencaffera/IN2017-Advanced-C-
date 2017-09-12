using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestScores
{
    public partial class MainWindow : Form
    {
        double Total;
        int Count;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            LabelResult.Visible = false;
            double Score = Convert.ToDouble(TextBoxScores.Text);
            if (Score < 0 || Score > 100)
            {
                LabelResult.Text = "You entered an invalid score.";
                LabelResult.Visible = true;
            }
            else
            {
                Total += Score;
                Count++;
            }
            TextBoxScores.Text = null;
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            double Average = Total / Count;
            LabelResult.Text = String.Format("You entered {0} scores.\rThe score average is {1}.", Count, Average);
            LabelResult.Visible = true;
            Total = 0;
            Count = 0;
        }
    }
}
