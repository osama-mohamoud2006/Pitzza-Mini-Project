using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refactored_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetAllControlsToDefaultValues();
        }

        /// <summary>
        ///  Update Price Section 
        /// </summary>
        /// <returns>Updated Price Label </returns>
        private float CalcPriceOfSize()//check what was checked then return its price 
        {
            if (rbSmall.Checked) // return true if it checked
                return Convert.ToSingle(rbSmall.Tag);

            if(rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);
           
            if(rbLarge.Checked)
                return Convert.ToSingle(rbLarge.Tag);

            return 0;
        }

        private float CalcPriceOfCurstType()//check what was checked then return its price 
        {
            if (rbThinCrust.Checked)
                return Convert.ToSingle(rbThinCrust.Tag);

            if(rbThickCrust.Checked)
                return Convert.ToSingle(rbThickCrust.Tag);
            return 0; 
        }
        
        private float CalcPriceOfToppings() // in check box you can check more than one check box,then calc what were checked
        {
            float total = 0;

            if (chkExtraChees.Checked)
                total += Convert.ToSingle(chkExtraChees.Tag);

            if(chkGreenPeppers.Checked)
                total += Convert.ToSingle(chkGreenPeppers.Tag);

            if(chkMushrooms.Checked)
                total += Convert.ToSingle(chkMushrooms.Tag);

            if(chkOlives.Checked)
                total += Convert.ToSingle(chkOlives.Tag);

            if(chkOnion.Checked)
                total += Convert.ToSingle(chkOnion.Tag);

            if(chkTomatos.Checked)
                total += Convert.ToSingle(chkTomatos.Tag);
            return total; 
        }

        private float GetTotalPrice() // take the price of each group then get the total of them 
        {
            return CalcPriceOfSize()+ CalcPriceOfCurstType()+ CalcPriceOfToppings();
        }

        private void UpdatePrice()//update price on screen 
        {
            lblTotalPrice.Text = "$"+GetTotalPrice().ToString();
        }


        private void Size_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSizeLabel(sender); //take the checked rb and update the size label in summary section  
            UpdatePrice();
        }

        private void Crust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCurstTypeLabel(sender); // take the current checked rb txt 
            UpdatePrice();

        }
        private void Topping_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToopingsLabel(); // check what is checked then update the toppings label in summary section
            UpdatePrice(); // calc what you checked with other groups also
        }


                             /// Update Summary Section ////
 
        private void UpdateSizeLabel(object sender)
        {
            RadioButton SelectedSize = (RadioButton)sender;
            lblSize.Text = SelectedSize.Text;
        }

        private void UpdateCurstTypeLabel(object sender)
        {
            RadioButton SelectedCurstType = (RadioButton)sender;
            lblCrustType.Text = SelectedCurstType.Text;
        }

        private void UpdateEatStatusLabel(object sender, EventArgs e)
        {
            RadioButton EatInOrOut = (RadioButton)sender;
            lblWhereToEat.Text = EatInOrOut.Text;
        }

        private void UpdateToopingsLabel()
        {
            string stToppings = "";
            string sep = ", ";
            if (chkExtraChees.Checked)
                stToppings += chkExtraChees.Text+sep;

            if(chkGreenPeppers.Checked)
                stToppings += chkGreenPeppers.Text+sep;

            if(chkMushrooms.Checked)
                stToppings += chkMushrooms.Text+sep;

            if(chkOlives.Checked)
                stToppings += chkOlives.Text+sep;

            if(chkOnion.Checked)
                stToppings += chkOnion.Text+sep;

            if(chkTomatos.Checked)
                stToppings += chkTomatos.Text+sep;

            if(stToppings!="") stToppings = stToppings.Substring(0, stToppings.Length - 2).Trim(); // to remove the last sep from the string

            lblToppings.Text = stToppings;
        }

     

                                  /// Order,Rest Section //// 

        private void DisableGroups()
        {
            gbCrustType.Enabled = false;
            gbSize.Enabled = false;
            gbToppings.Enabled = false;
            gbWhereToEat.Enabled = false;
        }
        private void SetAllControlsToDefaultValues()
        {
            rbEatIn.Checked = true;
           
            rbSmall.Checked = true;    
            rbThinCrust.Checked = true;

            // toppings
            chkExtraChees.Checked= false;
            chkMushrooms.Checked = false;
            chkGreenPeppers.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatos.Checked = false;


        }
        private void EnableGroups()
        {
            gbCrustType.Enabled = true;
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
        }
        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            var Res = MessageBox.Show("Are you sure you want to order?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                DisableGroups();
                btnOrderPizza.Enabled = false;
                MessageBox.Show("Your Order Has Been Confirmed","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnResetForm.Enabled = true;
            }
               
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to reset the form?", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                EnableGroups();
                SetAllControlsToDefaultValues();
                btnOrderPizza.Enabled = true;
                btnResetForm.Enabled = false;
            }
        }

      
    }

}
