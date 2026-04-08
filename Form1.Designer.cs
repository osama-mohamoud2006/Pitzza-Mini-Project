namespace Pizzza
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grbOfSizes = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.grbCrustTypes = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.grbTopping = new System.Windows.Forms.GroupBox();
            this.cbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.cbOlives = new System.Windows.Forms.CheckBox();
            this.cbOnion = new System.Windows.Forms.CheckBox();
            this.cbTomatomes = new System.Windows.Forms.CheckBox();
            this.cbMushrooms = new System.Windows.Forms.CheckBox();
            this.cbExtraCheese = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbEatin = new System.Windows.Forms.RadioButton();
            this.rbTakeout = new System.Windows.Forms.RadioButton();
            this.btnORDER = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.grbWhereToEat = new System.Windows.Forms.GroupBox();
            this.labPrice = new System.Windows.Forms.Label();
            this.grbSummary = new System.Windows.Forms.GroupBox();
            this.labWhereToEatSummary = new System.Windows.Forms.Label();
            this.grbWhereToEatSummary = new System.Windows.Forms.Label();
            this.grbCurstSummary = new System.Windows.Forms.GroupBox();
            this.labCurstSizeSummary = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labToppingsSummary = new System.Windows.Forms.Label();
            this.grbSizeSummary = new System.Windows.Forms.GroupBox();
            this.labSizeSummary = new System.Windows.Forms.Label();
            this.grbOfSizes.SuspendLayout();
            this.grbCrustTypes.SuspendLayout();
            this.grbTopping.SuspendLayout();
            this.grbWhereToEat.SuspendLayout();
            this.grbSummary.SuspendLayout();
            this.grbCurstSummary.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbSizeSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOfSizes
            // 
            this.grbOfSizes.BackColor = System.Drawing.Color.Black;
            this.grbOfSizes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grbOfSizes.Controls.Add(this.rbLarge);
            this.grbOfSizes.Controls.Add(this.rbMeduim);
            this.grbOfSizes.Controls.Add(this.rbSmall);
            this.grbOfSizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbOfSizes.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOfSizes.ForeColor = System.Drawing.Color.White;
            this.grbOfSizes.Location = new System.Drawing.Point(12, 12);
            this.grbOfSizes.Name = "grbOfSizes";
            this.grbOfSizes.Size = new System.Drawing.Size(215, 256);
            this.grbOfSizes.TabIndex = 0;
            this.grbOfSizes.TabStop = false;
            this.grbOfSizes.Text = "Size Of Pizza";
            this.grbOfSizes.Enter += new System.EventHandler(this.grbSize_Enter);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.Location = new System.Drawing.Point(15, 167);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(88, 28);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.Tag = "";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.UpdatePriceForSizesRadioButtons);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMeduim.Location = new System.Drawing.Point(15, 105);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(112, 28);
            this.rbMeduim.TabIndex = 1;
            this.rbMeduim.Tag = "";
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.UpdatePriceForSizesRadioButtons);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.Location = new System.Drawing.Point(15, 43);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(87, 28);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Tag = "";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.UpdatePriceForSizesRadioButtons);
            // 
            // grbCrustTypes
            // 
            this.grbCrustTypes.BackColor = System.Drawing.Color.Black;
            this.grbCrustTypes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grbCrustTypes.Controls.Add(this.rbThick);
            this.grbCrustTypes.Controls.Add(this.rbThin);
            this.grbCrustTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbCrustTypes.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCrustTypes.ForeColor = System.Drawing.Color.White;
            this.grbCrustTypes.Location = new System.Drawing.Point(12, 326);
            this.grbCrustTypes.Name = "grbCrustTypes";
            this.grbCrustTypes.Size = new System.Drawing.Size(215, 187);
            this.grbCrustTypes.TabIndex = 1;
            this.grbCrustTypes.TabStop = false;
            this.grbCrustTypes.Text = "Curst Type";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThick.Location = new System.Drawing.Point(15, 115);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(85, 28);
            this.rbThick.TabIndex = 2;
            this.rbThick.Tag = "";
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.UpdatePriceForCurstTypeRadioButtons);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThin.Location = new System.Drawing.Point(15, 64);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(75, 28);
            this.rbThin.TabIndex = 1;
            this.rbThin.Tag = "";
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.UpdatePriceForCurstTypeRadioButtons);
            // 
            // grbTopping
            // 
            this.grbTopping.BackColor = System.Drawing.Color.Black;
            this.grbTopping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grbTopping.Controls.Add(this.cbGreenPeppers);
            this.grbTopping.Controls.Add(this.cbOlives);
            this.grbTopping.Controls.Add(this.cbOnion);
            this.grbTopping.Controls.Add(this.cbTomatomes);
            this.grbTopping.Controls.Add(this.cbMushrooms);
            this.grbTopping.Controls.Add(this.cbExtraCheese);
            this.grbTopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbTopping.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTopping.ForeColor = System.Drawing.Color.White;
            this.grbTopping.Location = new System.Drawing.Point(233, 75);
            this.grbTopping.Name = "grbTopping";
            this.grbTopping.Size = new System.Drawing.Size(874, 256);
            this.grbTopping.TabIndex = 2;
            this.grbTopping.TabStop = false;
            this.grbTopping.Text = "Topping";
            // 
            // cbGreenPeppers
            // 
            this.cbGreenPeppers.AutoSize = true;
            this.cbGreenPeppers.Font = new System.Drawing.Font("SF Mono", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGreenPeppers.Location = new System.Drawing.Point(494, 183);
            this.cbGreenPeppers.Name = "cbGreenPeppers";
            this.cbGreenPeppers.Size = new System.Drawing.Size(299, 43);
            this.cbGreenPeppers.TabIndex = 5;
            this.cbGreenPeppers.Text = "Green Peppers";
            this.cbGreenPeppers.UseVisualStyleBackColor = true;
            this.cbGreenPeppers.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbOlives
            // 
            this.cbOlives.AutoSize = true;
            this.cbOlives.Font = new System.Drawing.Font("SF Mono", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOlives.Location = new System.Drawing.Point(494, 115);
            this.cbOlives.Name = "cbOlives";
            this.cbOlives.Size = new System.Drawing.Size(159, 43);
            this.cbOlives.TabIndex = 4;
            this.cbOlives.Text = "Olives";
            this.cbOlives.UseVisualStyleBackColor = true;
            this.cbOlives.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbOnion
            // 
            this.cbOnion.AutoSize = true;
            this.cbOnion.Font = new System.Drawing.Font("SF Mono", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOnion.Location = new System.Drawing.Point(494, 47);
            this.cbOnion.Name = "cbOnion";
            this.cbOnion.Size = new System.Drawing.Size(139, 43);
            this.cbOnion.TabIndex = 3;
            this.cbOnion.Text = "Onion";
            this.cbOnion.UseVisualStyleBackColor = true;
            this.cbOnion.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbTomatomes
            // 
            this.cbTomatomes.AutoSize = true;
            this.cbTomatomes.Font = new System.Drawing.Font("SF Mono", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTomatomes.Location = new System.Drawing.Point(25, 183);
            this.cbTomatomes.Name = "cbTomatomes";
            this.cbTomatomes.Size = new System.Drawing.Size(219, 43);
            this.cbTomatomes.TabIndex = 2;
            this.cbTomatomes.Text = "Tomatomes";
            this.cbTomatomes.UseVisualStyleBackColor = true;
            this.cbTomatomes.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbMushrooms
            // 
            this.cbMushrooms.AutoSize = true;
            this.cbMushrooms.Font = new System.Drawing.Font("SF Mono", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMushrooms.Location = new System.Drawing.Point(25, 115);
            this.cbMushrooms.Name = "cbMushrooms";
            this.cbMushrooms.Size = new System.Drawing.Size(219, 43);
            this.cbMushrooms.TabIndex = 1;
            this.cbMushrooms.Text = "Mushrooms";
            this.cbMushrooms.UseVisualStyleBackColor = true;
            this.cbMushrooms.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbExtraCheese
            // 
            this.cbExtraCheese.AutoSize = true;
            this.cbExtraCheese.Font = new System.Drawing.Font("SF Mono", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExtraCheese.Location = new System.Drawing.Point(25, 47);
            this.cbExtraCheese.Name = "cbExtraCheese";
            this.cbExtraCheese.Size = new System.Drawing.Size(279, 43);
            this.cbExtraCheese.TabIndex = 0;
            this.cbExtraCheese.Text = "Extra Cheese";
            this.cbExtraCheese.UseVisualStyleBackColor = true;
            this.cbExtraCheese.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(483, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pitzzaty";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "Where To Eat ?";
            // 
            // rbEatin
            // 
            this.rbEatin.AutoSize = true;
            this.rbEatin.BackColor = System.Drawing.Color.Transparent;
            this.rbEatin.FlatAppearance.BorderSize = 0;
            this.rbEatin.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbEatin.Location = new System.Drawing.Point(49, 21);
            this.rbEatin.Name = "rbEatin";
            this.rbEatin.Size = new System.Drawing.Size(117, 31);
            this.rbEatin.TabIndex = 5;
            this.rbEatin.TabStop = true;
            this.rbEatin.Text = "Eat in";
            this.rbEatin.UseVisualStyleBackColor = false;
            this.rbEatin.CheckedChanged += new System.EventHandler(this.rbEatin_CheckedChanged);
            // 
            // rbTakeout
            // 
            this.rbTakeout.AutoSize = true;
            this.rbTakeout.BackColor = System.Drawing.Color.Transparent;
            this.rbTakeout.FlatAppearance.BorderSize = 0;
            this.rbTakeout.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTakeout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbTakeout.Location = new System.Drawing.Point(49, 74);
            this.rbTakeout.Name = "rbTakeout";
            this.rbTakeout.Size = new System.Drawing.Size(145, 31);
            this.rbTakeout.TabIndex = 6;
            this.rbTakeout.TabStop = true;
            this.rbTakeout.Text = "Take out";
            this.rbTakeout.UseVisualStyleBackColor = false;
            this.rbTakeout.CheckedChanged += new System.EventHandler(this.rbEatin_CheckedChanged);
            // 
            // btnORDER
            // 
            this.btnORDER.AutoSize = true;
            this.btnORDER.BackColor = System.Drawing.Color.Gainsboro;
            this.btnORDER.Enabled = false;
            this.btnORDER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnORDER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnORDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnORDER.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnORDER.Location = new System.Drawing.Point(605, 428);
            this.btnORDER.Name = "btnORDER";
            this.btnORDER.Size = new System.Drawing.Size(131, 44);
            this.btnORDER.TabIndex = 8;
            this.btnORDER.Text = "Order Pizza";
            this.btnORDER.UseVisualStyleBackColor = false;
            this.btnORDER.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnRest
            // 
            this.btnRest.AutoSize = true;
            this.btnRest.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRest.Enabled = false;
            this.btnRest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRest.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRest.Location = new System.Drawing.Point(792, 428);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(131, 44);
            this.btnRest.TabIndex = 9;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // grbWhereToEat
            // 
            this.grbWhereToEat.BackColor = System.Drawing.Color.Black;
            this.grbWhereToEat.Controls.Add(this.rbTakeout);
            this.grbWhereToEat.Controls.Add(this.rbEatin);
            this.grbWhereToEat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbWhereToEat.Location = new System.Drawing.Point(303, 388);
            this.grbWhereToEat.Name = "grbWhereToEat";
            this.grbWhereToEat.Size = new System.Drawing.Size(234, 134);
            this.grbWhereToEat.TabIndex = 11;
            this.grbWhereToEat.TabStop = false;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.BackColor = System.Drawing.Color.Transparent;
            this.labPrice.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrice.ForeColor = System.Drawing.Color.LimeGreen;
            this.labPrice.Location = new System.Drawing.Point(98, 441);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(77, 59);
            this.labPrice.TabIndex = 0;
            this.labPrice.Text = "0$";
            // 
            // grbSummary
            // 
            this.grbSummary.BackColor = System.Drawing.Color.Black;
            this.grbSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grbSummary.Controls.Add(this.labWhereToEatSummary);
            this.grbSummary.Controls.Add(this.grbWhereToEatSummary);
            this.grbSummary.Controls.Add(this.grbCurstSummary);
            this.grbSummary.Controls.Add(this.groupBox2);
            this.grbSummary.Controls.Add(this.grbSizeSummary);
            this.grbSummary.Controls.Add(this.labPrice);
            this.grbSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbSummary.Font = new System.Drawing.Font("SF Pro Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSummary.ForeColor = System.Drawing.Color.White;
            this.grbSummary.Location = new System.Drawing.Point(1113, 0);
            this.grbSummary.Name = "grbSummary";
            this.grbSummary.Size = new System.Drawing.Size(297, 535);
            this.grbSummary.TabIndex = 0;
            this.grbSummary.TabStop = false;
            this.grbSummary.Text = "      Summary";
            // 
            // labWhereToEatSummary
            // 
            this.labWhereToEatSummary.BackColor = System.Drawing.Color.Transparent;
            this.labWhereToEatSummary.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWhereToEatSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labWhereToEatSummary.Location = new System.Drawing.Point(151, 383);
            this.labWhereToEatSummary.Name = "labWhereToEatSummary";
            this.labWhereToEatSummary.Size = new System.Drawing.Size(133, 22);
            this.labWhereToEatSummary.TabIndex = 6;
            // 
            // grbWhereToEatSummary
            // 
            this.grbWhereToEatSummary.BackColor = System.Drawing.Color.Transparent;
            this.grbWhereToEatSummary.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbWhereToEatSummary.ForeColor = System.Drawing.Color.White;
            this.grbWhereToEatSummary.Location = new System.Drawing.Point(12, 383);
            this.grbWhereToEatSummary.Name = "grbWhereToEatSummary";
            this.grbWhereToEatSummary.Size = new System.Drawing.Size(241, 22);
            this.grbWhereToEatSummary.TabIndex = 5;
            this.grbWhereToEatSummary.Text = "Where To Eat:";
            // 
            // grbCurstSummary
            // 
            this.grbCurstSummary.BackColor = System.Drawing.Color.Black;
            this.grbCurstSummary.Controls.Add(this.labCurstSizeSummary);
            this.grbCurstSummary.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCurstSummary.ForeColor = System.Drawing.Color.White;
            this.grbCurstSummary.Location = new System.Drawing.Point(20, 120);
            this.grbCurstSummary.Name = "grbCurstSummary";
            this.grbCurstSummary.Size = new System.Drawing.Size(200, 45);
            this.grbCurstSummary.TabIndex = 2;
            this.grbCurstSummary.TabStop = false;
            this.grbCurstSummary.Text = "Curst Size";
            // 
            // labCurstSizeSummary
            // 
            this.labCurstSizeSummary.AutoSize = true;
            this.labCurstSizeSummary.Location = new System.Drawing.Point(6, 21);
            this.labCurstSizeSummary.Name = "labCurstSizeSummary";
            this.labCurstSizeSummary.Size = new System.Drawing.Size(0, 18);
            this.labCurstSizeSummary.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.labToppingsSummary);
            this.groupBox2.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(20, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 197);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toopings";
            // 
            // labToppingsSummary
            // 
            this.labToppingsSummary.AutoSize = true;
            this.labToppingsSummary.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToppingsSummary.Location = new System.Drawing.Point(21, 41);
            this.labToppingsSummary.Name = "labToppingsSummary";
            this.labToppingsSummary.Size = new System.Drawing.Size(0, 20);
            this.labToppingsSummary.TabIndex = 0;
            // 
            // grbSizeSummary
            // 
            this.grbSizeSummary.Controls.Add(this.labSizeSummary);
            this.grbSizeSummary.Font = new System.Drawing.Font("SF Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSizeSummary.ForeColor = System.Drawing.Color.White;
            this.grbSizeSummary.Location = new System.Drawing.Point(20, 54);
            this.grbSizeSummary.Name = "grbSizeSummary";
            this.grbSizeSummary.Size = new System.Drawing.Size(200, 45);
            this.grbSizeSummary.TabIndex = 1;
            this.grbSizeSummary.TabStop = false;
            this.grbSizeSummary.Text = "size";
            // 
            // labSizeSummary
            // 
            this.labSizeSummary.AutoSize = true;
            this.labSizeSummary.Location = new System.Drawing.Point(6, 21);
            this.labSizeSummary.Name = "labSizeSummary";
            this.labSizeSummary.Size = new System.Drawing.Size(0, 18);
            this.labSizeSummary.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1408, 534);
            this.Controls.Add(this.grbWhereToEat);
            this.Controls.Add(this.grbSummary);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnORDER);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbTopping);
            this.Controls.Add(this.grbCrustTypes);
            this.Controls.Add(this.grbOfSizes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pitzzaty";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grbOfSizes.ResumeLayout(false);
            this.grbOfSizes.PerformLayout();
            this.grbCrustTypes.ResumeLayout(false);
            this.grbCrustTypes.PerformLayout();
            this.grbTopping.ResumeLayout(false);
            this.grbTopping.PerformLayout();
            this.grbWhereToEat.ResumeLayout(false);
            this.grbWhereToEat.PerformLayout();
            this.grbSummary.ResumeLayout(false);
            this.grbSummary.PerformLayout();
            this.grbCurstSummary.ResumeLayout(false);
            this.grbCurstSummary.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbSizeSummary.ResumeLayout(false);
            this.grbSizeSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOfSizes;
        private System.Windows.Forms.GroupBox grbCrustTypes;
        private System.Windows.Forms.GroupBox grbTopping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.CheckBox cbExtraCheese;
        private System.Windows.Forms.CheckBox cbGreenPeppers;
        private System.Windows.Forms.CheckBox cbOlives;
        private System.Windows.Forms.CheckBox cbOnion;
        private System.Windows.Forms.CheckBox cbTomatomes;
        private System.Windows.Forms.CheckBox cbMushrooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbEatin;
        private System.Windows.Forms.RadioButton rbTakeout;
        private System.Windows.Forms.Button btnORDER;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.GroupBox grbWhereToEat;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.GroupBox grbSummary;
        private System.Windows.Forms.GroupBox grbSizeSummary;
        private System.Windows.Forms.Label labSizeSummary;
        private System.Windows.Forms.GroupBox grbCurstSummary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labToppingsSummary;
        private System.Windows.Forms.Label labCurstSizeSummary;
        private System.Windows.Forms.Label grbWhereToEatSummary;
        private System.Windows.Forms.Label labWhereToEatSummary;
    }
}

