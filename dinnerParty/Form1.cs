using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinnerParty
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty();
            dinnerParty.CalculateCostOfDecoration(radioFancy.Checked);
            dinnerParty.SetHealthyOption(radioHealthy.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(radioFancy.Checked, radioHealthy.Checked);
            labelTotal.Text = Cost.ToString("c");
            //string formatting will interpret c as local currency, using ToString method
        }

        private void radioFancy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecoration(radioFancy.Checked);
            DisplayDinnerPartyCost();
        }

        private void radioHealthy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(radioHealthy.Checked);
            DisplayDinnerPartyCost();
        }

        private void numericGuests_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericGuests.Value;
            DisplayDinnerPartyCost();
        }
    }
}
