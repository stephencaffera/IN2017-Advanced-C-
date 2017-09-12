using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class MainWindow : Form
    {
        int RandomNumber;
        public MainWindow()
        {
            RandomNumber = Program.RandomNumber();
            InitializeComponent();
        }

        private void ButtonGuess_Click(object sender, EventArgs e)
        {
            int Guess = Convert.ToInt32(TextBoxGuess.Text);
            if (Guess > RandomNumber) LabelResult.Text = "Too high.";
            else if (Guess < RandomNumber) LabelResult.Text = "Too low.";
            else LabelResult.Text = "Correct!";

            RandomNumber = Program.RandomNumber();
            LabelResult.Visible = true;
        }
    }
}
