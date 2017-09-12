using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumInts
{
    public partial class MainWindow : Form
    {
        int Total;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            int Number = Convert.ToInt32(TextBoxNumber.Text);
            if (Number == 999)
            {
                LabelTotal.Text = String.Format("Your total is {0}.", Total);
                Total = 0;
                LabelTotal.Visible = true;
            }
            else
            {
                Total += Number;
                TextBoxNumber.Text = null;
            }
        }
    }
}
