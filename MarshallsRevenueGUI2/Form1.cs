using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarshallsRevenueGUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            int MuralsExterior = Convert.ToInt32(TextBoxExterior.Text);
            int MuralsInterior = Convert.ToInt32(TextBoxInterior.Text);
            int Month = Convert.ToInt32(TextBoxMonth.Text);
            bool ValidMuralValues = true;
            bool ValidMonthValue = true;

            if (MuralsExterior < 0 || MuralsExterior > 30 || MuralsInterior < 0 || MuralsInterior > 30)
            {
                ValidMuralValues = false;
            }
            if(Month < 0 || Month > 12)
            {
                ValidMonthValue = false;
            }
            if (!ValidMuralValues || !ValidMonthValue)
            {
                OrderHeader.Text = "Please ensure the month value ranges from 0 to 12\rand the mural values range from 0 to 30.";
                return;
            }

            int MuralsExteriorCost = MuralsExterior * 750;
            int MuralsInteriorCost = MuralsInterior * 500;
            int MuralsTotal = MuralsExterior + MuralsInterior;
            int MuralsTotalCost = MuralsExteriorCost + MuralsInteriorCost;

            OrderHeader.Text = "Order Details:";
            LabelOrderExterior.Text = String.Format("Exterior murals: {0} ({1} for $750)", MuralsExteriorCost, MuralsExterior);
            LabelOrderInterior.Text = String.Format("Interior murals: {0} ({1} for $500)", MuralsInteriorCost, MuralsInterior);
            LabelOrderTotal.Text = String.Format("Total: {0:C2}.{1}", MuralsTotalCost, MuralsInterior > MuralsExterior ? " More interior murals were scheduled than exterior ones.": "");
            LabelOrderExterior.Visible = true;
            LabelOrderInterior.Visible = true;
            LabelOrderTotal.Visible = true;
        }
    }
}
