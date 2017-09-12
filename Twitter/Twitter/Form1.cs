using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitter
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            LabelConfirmation.Visible = false;

            String Message = TextBoxMessage.Text;
            if (Message.Length <= 140) LabelConfirmation.Text = "Your message has a valid length.";
            else LabelConfirmation.Text = "Your message is too long.";

            LabelConfirmation.Visible = true;
        }
    }
}
