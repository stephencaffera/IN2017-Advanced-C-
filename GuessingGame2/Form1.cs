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
        int NumberOfGuesses = 0;
        public MainWindow()
        {
            RandomNumber = Program.RandomNumber();
            InitializeComponent();
        }

        private void ButtonGuess_Click(object sender, EventArgs e)
        {
            int Guess = Convert.ToInt32(TextBoxGuess.Text);
            NumberOfGuesses++;
            if (Guess > RandomNumber) LabelResult.Text = "Too high.";
            else if (Guess < RandomNumber) LabelResult.Text = "Too low.";
            else
            {
                LabelResult.Text = String.Format("Correct! You made {0} guesses.", NumberOfGuesses);
                RandomNumber = Program.RandomNumber();
            }

            LabelResult.Visible = true;
        }
    }
}
