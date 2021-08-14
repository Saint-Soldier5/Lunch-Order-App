using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        decimal addOn = 0m;
        decimal basePrice = 0m;
        decimal mySubtotal = 0m;
        decimal tax = 0m;
        decimal myTotal = 0m;
        int addOnCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void radHamburger_CheckedChanged(object sender, EventArgs e)
        {
            
            RadioButton s = (RadioButton)sender;
            switch (s.Name)
            {
                case "radPizza":
                    groupBoxAddOn.Text = "Add-on items ($.50/each)";
                    chkBoxLettuce.Text = "Pepperoni";
                    chkBoxKetchup.Text = "Sausage";
                    chkBoxFrench.Text = "Olives";
                    addOn = 0.50m;
                    basePrice = 5.95m;
                    break;
                case "radSalad":
                    groupBoxAddOn.Text = "Add-on items ($.25/each)";
                    chkBoxLettuce.Text = "Croutons";
                    chkBoxKetchup.Text = "Bacon bits";
                    chkBoxFrench.Text = "Bread sticks";
                    addOn = 0.25m;
                    basePrice = 4.95m;
                    break;
              
            
                default:
                    groupBoxAddOn.Text = "Add - on items($.75 / each)";
                    chkBoxLettuce.Text = "Lettuce, Tomato, Onions";
                    chkBoxKetchup.Text = "Ketchup,Mustard, Mayo";
                    chkBoxFrench.Text = "French Fries";
                    addOn = 0.75m;
                    basePrice = 6.95m;
                    break;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (chkBoxLettuce.Checked)
                addOnCounter++;
            if (chkBoxKetchup.Checked)
                addOnCounter++;
            if (chkBoxFrench.Checked)
                addOnCounter++;
            mySubtotal = basePrice+addOn*addOnCounter;
            tax = 0.05m * mySubtotal;
            myTotal = tax + mySubtotal;
            lblSubtotal.Text = mySubtotal.ToString("c");
            lblTax.Text = tax.ToString("c");
            lblTotal.Text = myTotal.ToString("c");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mySubtotal = 0m;
            tax = 0m;
            myTotal = 0m;
            addOn = 0m;
            basePrice = 0m;
            addOnCounter = 0;
            lblSubtotal.Text = "";
            lblTax.Text = "";
            lblTotal.Text = "";
            chkBoxLettuce.Checked = false;
            chkBoxKetchup.Checked = false;
            chkBoxFrench.Checked = false;
            radHamburger.Checked = false;
            radPizza.Checked = false;
            radSalad.Checked = false;
        }

        private void chkBoxLettuce_CheckedChanged(object sender, EventArgs e)
        {
            //addOnCounter++;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
