using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzza
{
    public partial class frmMain : Form
    {
        private double _TotalPrice=0;

        public frmMain()
        {
            InitializeComponent();
            AssignTagsValuesForRadioButtons(); // for assigning values for radio controls.tag
            AssignTagsValuesForCheckBoxes(); // for assigning values for check boxes  controls.tag
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnORDER.Enabled = false;
            btnRest.Enabled = true;
        }

        private struct stDataForEachTag
        {
            public string name ;
            public float price;
 
        }

       private stDataForEachTag DataForEachTag; // instance of struct to use it as temp variable 

       
        /// The Section Of grb1,2 for radio buttons 
       
        
        // This Function Is Used To Assign Name,Price For Each Control Tag (radio buttons) 
        // it runs when form loads 
        private void AssignTagsValuesForRadioButtons()
        {
            
            string[] NameOfEachRB = {"Small","Medium","Large","Thin","Thick"}; // name of each rb control 
            float[] PricesForEachRB= {10,20,30,2,5}; // price of each rb control 

            RadioButton[] Rb = { rbSmall ,rbMeduim ,rbLarge ,rbThin , rbThick}; // the radio buttons itself 

            int i = 0; // to access array 
            foreach (RadioButton item in Rb)
            {
                //DataForEachTag.name = NameOfEachRB[i];
                DataForEachTag.price = PricesForEachRB[i];
                Rb[i].Tag = DataForEachTag; // assign the struct to each  rb tag 
                i += 1; // increment the index 
            }

        }


        // This Function Is Used To Assign Name,Price For Each Control Tag (check boxes )
        // it runs when form loads 
        private void AssignTagsValuesForCheckBoxes()
        {
            // Rectangle 2D array 3*2
            string[,] NameOfEachRB = 
             {
                {"Extra Cheese","Onion"}  // R1
               ,{"Mushrooms","Olives"}//R2
               ,{"Tomatoes","Green Peppers"}//R3
            }; 
            
           
            float[,] PricesForEachRB = 
                {
                  {2.70f,1.60f} ,//R1
                  {2.1f,1.4f}, //R2
                   {1.99f,1.40f }//R3
                  
                 };

            CheckBox[,] CB = 
             {
                { cbExtraCheese , cbOnion},
                {cbMushrooms,cbOlives },
                {cbTomatomes,cbGreenPeppers }
            }; 

        

            for(int i=0; i< NameOfEachRB.GetLength(0); i++)
            {
                for (int j = 0; j < NameOfEachRB.GetLength(1); j++)
                {
                   // DataForEachTag.name = NameOfEachRB[i, j];
                    DataForEachTag.price = PricesForEachRB[i, j];
                    CB[i, j].Tag = DataForEachTag;
                }

            }

        }

        // ----------------------------------------------------------------------------------------------------------//

        // to call it after updating price (on screen on the real time) 
        private void UpdatePriceLabel()
        {
            if ( 0 > _TotalPrice)
            {
                _TotalPrice = 0;
            }
            labPrice.Text = Convert.ToString(Math.Ceiling(_TotalPrice)) + "$";
        }

        private void grbSize_Enter(object sender, EventArgs e)
        {
            btnORDER.Enabled = true;
            
        }

        private void  SetLabelForSizeSummary(object sender) // FOR RADIO BUTTON GROUP1 
        {
            RadioButton SelectedOption = (RadioButton)sender;
            labSizeSummary.Text = SelectedOption.Text; 
        }

        private void SetLabelCurstSummary(object sender) // FOR RADIO BUTTON GROUP1 
        {
            RadioButton SelectedOption = (RadioButton)sender;
            labCurstSizeSummary.Text = SelectedOption.Text;
        }


        // For The First Group "Radio Button Of Select Size" /// --> don't touch it //////
        private RadioButton TheLastRbOfSize = null; // to store the last user choice of radio buttons(size)
        private void UpdatePriceForSizesRadioButtons(object sender, EventArgs e)
        {
            if (TheLastRbOfSize != null) // get rid of the last operation price user did 
            {
                stDataForEachTag DataForRB = (stDataForEachTag)TheLastRbOfSize.Tag;
                this._TotalPrice -= DataForRB.price;
              
            }

            RadioButton[] Group1OfSizes = { rbSmall, rbMeduim, rbLarge};

            foreach (RadioButton RB in Group1OfSizes)
            {
                if (RB.Checked) // if one of radio buttons was checked,then add the price to total 
                {
                    stDataForEachTag DataForRB = (stDataForEachTag)RB.Tag; // take each tag and cast to to stuct to get its price
                    this._TotalPrice += DataForRB.price;
                    TheLastRbOfSize = RB; // stores the last operation  
                }
            }

            UpdatePriceLabel();
            SetLabelForSizeSummary(sender);
        }


        // For The First Group "Radio Button Of Select Crust" /// --> don't touch it //////
        private RadioButton TheLastRbOfCurstType = null; // to store the last user choice of radio buttons(crust type)
        private void UpdatePriceForCurstTypeRadioButtons(object sender, EventArgs e)
        {
            if (TheLastRbOfCurstType != null) // get rid of the last operation price user did 
            {
                stDataForEachTag DataForRB = (stDataForEachTag)TheLastRbOfCurstType.Tag;
                this._TotalPrice -= DataForRB.price;

            }

            RadioButton[] Group2OfCurstTypes = { rbThin, rbThick };

            foreach (RadioButton RB2 in Group2OfCurstTypes)
            {
                if (RB2.Checked) // if one of radio buttons was checked,then add the price to total 
                {
                    stDataForEachTag DataForRB = (stDataForEachTag)RB2.Tag; // take each tag and cast to to stuct to get its price
                    this._TotalPrice += DataForRB.price;
                    TheLastRbOfCurstType = RB2; // stores the last operation  
                }
            }

            UpdatePriceLabel();
            SetLabelCurstSummary(sender);
        }

        private void rbEatin_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton where = (RadioButton)sender;
            this.labWhereToEatSummary.Text = where.Text;
        }


        ///  Check Boxes Logic //////////////////
        private void SetLabelForSummaryToppining()
        {
            labToppingsSummary.Text = "";
            CheckBox[] Cb = { cbExtraCheese, cbOnion, cbMushrooms, cbOlives, cbTomatomes, cbGreenPeppers };

            foreach (var item in Cb)
            {
                if (item.Checked)
                {

                    labToppingsSummary.Text += item.Text + "\n";
                }
            }
          //  if (labToppingsSummary.Text == "") this._TotalPrice = 0; // if user uncheck all check boxes, the price should be 0 for toppings
        }


        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox CB = (CheckBox)sender;
            stDataForEachTag DataForEachCheckBox = (stDataForEachTag)CB.Tag;

            if(CB.Checked)
            {
                this._TotalPrice += DataForEachCheckBox.price;

                SetLabelForSummaryToppining(); // loop each time and check what was changed and update the text

            }
            else
            {
                this._TotalPrice -= DataForEachCheckBox.price;
                SetLabelForSummaryToppining(); // loop each time and check what was changed and update the text
            }

            //
            UpdatePriceLabel();
           
        }


                   
         
              //////////////////  Un Section ////////////
             
                   
        private void UnCheckAllCheckBoxes() // make all check boxes unchecked 
        {
            CheckBox[] Cb = { cbExtraCheese, cbOnion, cbMushrooms, cbOlives, cbTomatomes, cbGreenPeppers };

            foreach (var item in Cb)
            {
                if (item.CheckState == CheckState.Checked) item.Checked = false;
            }


        }

        private void UncheckAllRadioBtns()
        {
            RadioButton[] Group1OfSizes = { rbSmall, rbMeduim, rbLarge };
            foreach (RadioButton RB in Group1OfSizes)
            {
                if (RB.Checked) RB.Checked = false;
            }
        }

        private void UncheckAllRadioBtnsForCurstType()
        {
            RadioButton[] Group2OfCurstTypes = { rbThin, rbThick };
            foreach (RadioButton RB2 in Group2OfCurstTypes)
            {
                if (RB2.Checked) RB2.Checked = false;
            }
        }

        private void UncheckAllWhereToEat()
        {
            RadioButton[] Group2OfCurstTypes = { rbTakeout, rbEatin };
            foreach (RadioButton RB2 in Group2OfCurstTypes)
            {
                if (RB2.Checked) RB2.Checked = false;
            }
        }


        private void DisableGroupsForOrder()
        {
            grbCrustTypes.Enabled = false;
            grbOfSizes.Enabled = false;
            grbTopping.Enabled = false;
            grbWhereToEat.Enabled = false;
            grbTopping.Enabled = false;

        }

        private void RestAllControls()
        {


            UnCheckAllCheckBoxes(); // uncheck all check boxes
              UncheckAllRadioBtns(); // disable group of sizes (radio buttons)
            UncheckAllRadioBtnsForCurstType();
             UncheckAllWhereToEat();


            // For New Order 
            this._TotalPrice = 0;
            labSizeSummary.Text = "";
            labToppingsSummary.Text = "";
            labPrice.Text = "";
            TheLastRbOfSize = null;
            TheLastRbOfCurstType = null;
            labWhereToEatSummary.Text = "";
            labCurstSizeSummary.Text = "";
           


            btnORDER.Enabled = true;
            grbCrustTypes.Enabled = true;
            grbCurstSummary.Enabled = true;
            grbOfSizes.Enabled = true;
         //   grbSizeSummary.Enabled = true;
            grbTopping.Enabled = true;
            grbWhereToEat.Enabled = true;
            grbTopping.Enabled = true;


            this._TotalPrice = 0;
            labSizeSummary.Text = "";
            labToppingsSummary.Text = "";
            labPrice.Text = "";
            TheLastRbOfSize = null;
            TheLastRbOfCurstType = null;

        }


                    // Order , Rest Buttons .............
        private void btnRest_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure About Resting ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (res == DialogResult.Yes)
            {
                RestAllControls();
                btnORDER.Enabled = false;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            btnRest.Enabled = true; 
           DialogResult res = MessageBox.Show("Are You Sure ?", "Confirmation Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(res == DialogResult.OK)
            {
                DisableGroupsForOrder();
                MessageBox.Show("Your Order Was Done!", "Message", MessageBoxButtons.OK);
                btnORDER.Enabled = false;
            }
        }

     
    }
}
