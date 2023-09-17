using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator
{
    public partial class ChangeCalculatorForm : Form
    {
        public ChangeCalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int change = Convert.ToInt32(ChangeDueTextbox.Text);
            int remainder = 0;
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            int pennies = 0;

            quarters = change/25;
            remainder = change - (quarters * 25);
            if(remainder != 0)
            {
                dimes = remainder / 10;
                remainder = remainder - (dimes*10);
            }
            if (remainder != 0)
            {
                nickels = remainder / 5;
                remainder = remainder - (nickels * 5);
            }
            if (remainder != 0)
            {
                pennies = remainder / 1;
                remainder = 0;
            }
            QuartersTextbox.Text = quarters.ToString();
            DimesTextbox.Text = dimes.ToString();
            NickelsTextbox.Text = nickels.ToString();
            PenniesTextbox.Text = pennies.ToString();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
