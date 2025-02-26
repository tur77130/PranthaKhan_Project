namespace sandwichbuilde
{
    partial class frmOrder
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhonenumber = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblzipcode = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblCustomerinfo = new System.Windows.Forms.Label();
            this.rdoPickup = new System.Windows.Forms.RadioButton();
            this.rdoDelivery = new System.Windows.Forms.RadioButton();
            this.lblSize = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblTips = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblprinttotal = new System.Windows.Forms.Label();
            this.txtTips = new System.Windows.Forms.TextBox();
            this.grpDeliveryPickup = new System.Windows.Forms.GroupBox();
            this.grpSandwichSelection = new System.Windows.Forms.GroupBox();
            this.rdoCustom = new System.Windows.Forms.RadioButton();
            this.rdoPreMade = new System.Windows.Forms.RadioButton();
            this.cboPreMadeSandwiches = new System.Windows.Forms.ComboBox();
            this.lblprelist = new System.Windows.Forms.Label();
            this.picSandwichImage = new System.Windows.Forms.PictureBox();
            this.lblSandwichDescription = new System.Windows.Forms.Label();
            this.lblCustomsandwich = new System.Windows.Forms.Label();
            this.lblbread = new System.Windows.Forms.Label();
            this.cboBreadType = new System.Windows.Forms.ComboBox();
            this.chkMayo = new System.Windows.Forms.CheckBox();
            this.chkHoneymustrd = new System.Windows.Forms.CheckBox();
            this.chkRanch = new System.Windows.Forms.CheckBox();
            this.chkSIgnature = new System.Windows.Forms.CheckBox();
            this.chkChicken = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkRostBeef = new System.Windows.Forms.CheckBox();
            this.chkBrisket = new System.Windows.Forms.CheckBox();
            this.chlLettuce = new System.Windows.Forms.CheckBox();
            this.chkSweetPeppers = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTommato = new System.Windows.Forms.CheckBox();
            this.lblTotaldisplay = new System.Windows.Forms.Label();
            this.grpMeat = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grpTopping = new System.Windows.Forms.GroupBox();
            this.grpSauces = new System.Windows.Forms.GroupBox();
            this.grpPremium = new System.Windows.Forms.GroupBox();
            this.chkextraRoastbeef = new System.Windows.Forms.CheckBox();
            this.chkExtraHam = new System.Windows.Forms.CheckBox();
            this.chkExtraChicken = new System.Windows.Forms.CheckBox();
            this.lblIngafiance = new System.Windows.Forms.Label();
            this.grpDeliveryPickup.SuspendLayout();
            this.grpSandwichSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSandwichImage)).BeginInit();
            this.grpMeat.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpTopping.SuspendLayout();
            this.grpSauces.SuspendLayout();
            this.grpPremium.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Location = new System.Drawing.Point(25, 147);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(123, 20);
            this.lblPhonenumber.TabIndex = 2;
            this.lblPhonenumber.Text = "Phone Number :";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(25, 203);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(76, 20);
            this.lbladdress.TabIndex = 3;
            this.lbladdress.Text = "Address :";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(40, 242);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 20);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City :";
            // 
            // lblzipcode
            // 
            this.lblzipcode.AutoSize = true;
            this.lblzipcode.Location = new System.Drawing.Point(40, 292);
            this.lblzipcode.Name = "lblzipcode";
            this.lblzipcode.Size = new System.Drawing.Size(39, 20);
            this.lblzipcode.TabIndex = 5;
            this.lblzipcode.Text = "Zip :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 26);
            this.txtName.TabIndex = 6;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(155, 144);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(179, 26);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(112, 200);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(195, 26);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(112, 239);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(128, 26);
            this.txtcity.TabIndex = 9;
            this.txtcity.TextChanged += new System.EventHandler(this.txtcity_TextChanged);
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(101, 286);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(128, 26);
            this.txtZip.TabIndex = 10;
            this.txtZip.TextChanged += new System.EventHandler(this.txtZip_TextChanged);
            // 
            // lblCustomerinfo
            // 
            this.lblCustomerinfo.AutoSize = true;
            this.lblCustomerinfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCustomerinfo.Location = new System.Drawing.Point(75, 47);
            this.lblCustomerinfo.Name = "lblCustomerinfo";
            this.lblCustomerinfo.Size = new System.Drawing.Size(110, 20);
            this.lblCustomerinfo.TabIndex = 20;
            this.lblCustomerinfo.Text = "Customer Info";
            this.lblCustomerinfo.Click += new System.EventHandler(this.lblCustomerinfo_Click);
            // 
            // rdoPickup
            // 
            this.rdoPickup.AutoSize = true;
            this.rdoPickup.Location = new System.Drawing.Point(17, 25);
            this.rdoPickup.Name = "rdoPickup";
            this.rdoPickup.Size = new System.Drawing.Size(81, 24);
            this.rdoPickup.TabIndex = 21;
            this.rdoPickup.TabStop = true;
            this.rdoPickup.Text = "Pickup";
            this.rdoPickup.UseVisualStyleBackColor = true;
            this.rdoPickup.CheckedChanged += new System.EventHandler(this.rdoPickup_CheckedChanged);
            // 
            // rdoDelivery
            // 
            this.rdoDelivery.AutoSize = true;
            this.rdoDelivery.Location = new System.Drawing.Point(17, 66);
            this.rdoDelivery.Name = "rdoDelivery";
            this.rdoDelivery.Size = new System.Drawing.Size(89, 24);
            this.rdoDelivery.TabIndex = 22;
            this.rdoDelivery.TabStop = true;
            this.rdoDelivery.Text = "Delivery";
            this.rdoDelivery.UseVisualStyleBackColor = true;
            this.rdoDelivery.CheckedChanged += new System.EventHandler(this.rdoDelivery_CheckedChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(812, 144);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(48, 20);
            this.lblSize.TabIndex = 25;
            this.lblSize.Text = "Size :";
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "Small",
            "Mediem",
            "Large"});
            this.cboSize.Location = new System.Drawing.Point(886, 141);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(135, 28);
            this.cboSize.TabIndex = 26;
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cboSize_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(32, 795);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(203, 47);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1161, 810);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(203, 47);
            this.btnNext.TabIndex = 28;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblTips
            // 
            this.lblTips.AutoSize = true;
            this.lblTips.Location = new System.Drawing.Point(1088, 619);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(46, 20);
            this.lblTips.TabIndex = 29;
            this.lblTips.Text = "Tips :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1088, 666);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 20);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "Total :";
            // 
            // lblprinttotal
            // 
            this.lblprinttotal.AutoSize = true;
            this.lblprinttotal.Location = new System.Drawing.Point(1179, 666);
            this.lblprinttotal.Name = "lblprinttotal";
            this.lblprinttotal.Size = new System.Drawing.Size(0, 20);
            this.lblprinttotal.TabIndex = 31;
            // 
            // txtTips
            // 
            this.txtTips.Location = new System.Drawing.Point(1151, 616);
            this.txtTips.Name = "txtTips";
            this.txtTips.Size = new System.Drawing.Size(107, 26);
            this.txtTips.TabIndex = 32;
            this.txtTips.TextChanged += new System.EventHandler(this.txtTips_TextChanged);
            // 
            // grpDeliveryPickup
            // 
            this.grpDeliveryPickup.Controls.Add(this.rdoPickup);
            this.grpDeliveryPickup.Controls.Add(this.rdoDelivery);
            this.grpDeliveryPickup.Location = new System.Drawing.Point(12, 419);
            this.grpDeliveryPickup.Name = "grpDeliveryPickup";
            this.grpDeliveryPickup.Size = new System.Drawing.Size(193, 106);
            this.grpDeliveryPickup.TabIndex = 33;
            this.grpDeliveryPickup.TabStop = false;
            this.grpDeliveryPickup.Text = "Select";
            this.grpDeliveryPickup.Enter += new System.EventHandler(this.grpDeliveryPickup_Enter);
            // 
            // grpSandwichSelection
            // 
            this.grpSandwichSelection.Controls.Add(this.rdoCustom);
            this.grpSandwichSelection.Controls.Add(this.rdoPreMade);
            this.grpSandwichSelection.Location = new System.Drawing.Point(12, 555);
            this.grpSandwichSelection.Name = "grpSandwichSelection";
            this.grpSandwichSelection.Size = new System.Drawing.Size(193, 96);
            this.grpSandwichSelection.TabIndex = 34;
            this.grpSandwichSelection.TabStop = false;
            this.grpSandwichSelection.Text = "Select Sandwich";
            this.grpSandwichSelection.Enter += new System.EventHandler(this.grpSandwichSelection_Enter);
            // 
            // rdoCustom
            // 
            this.rdoCustom.AutoSize = true;
            this.rdoCustom.Location = new System.Drawing.Point(20, 55);
            this.rdoCustom.Name = "rdoCustom";
            this.rdoCustom.Size = new System.Drawing.Size(162, 24);
            this.rdoCustom.TabIndex = 36;
            this.rdoCustom.TabStop = true;
            this.rdoCustom.Text = "Custom Sandwich";
            this.rdoCustom.UseVisualStyleBackColor = true;
            this.rdoCustom.CheckedChanged += new System.EventHandler(this.rdoCustom_CheckedChanged);
            // 
            // rdoPreMade
            // 
            this.rdoPreMade.AutoSize = true;
            this.rdoPreMade.Location = new System.Drawing.Point(17, 25);
            this.rdoPreMade.Name = "rdoPreMade";
            this.rdoPreMade.Size = new System.Drawing.Size(176, 24);
            this.rdoPreMade.TabIndex = 35;
            this.rdoPreMade.TabStop = true;
            this.rdoPreMade.Text = "Pre-Made Sandwich";
            this.rdoPreMade.UseVisualStyleBackColor = true;
            this.rdoPreMade.CheckedChanged += new System.EventHandler(this.rdoPreMade_CheckedChanged);
            // 
            // cboPreMadeSandwiches
            // 
            this.cboPreMadeSandwiches.FormattingEnabled = true;
            this.cboPreMadeSandwiches.Location = new System.Drawing.Point(352, 315);
            this.cboPreMadeSandwiches.Name = "cboPreMadeSandwiches";
            this.cboPreMadeSandwiches.Size = new System.Drawing.Size(170, 28);
            this.cboPreMadeSandwiches.TabIndex = 35;
            this.cboPreMadeSandwiches.SelectedIndexChanged += new System.EventHandler(this.cboPreMadeSandwiches_SelectedIndexChanged);
            // 
            // lblprelist
            // 
            this.lblprelist.AutoSize = true;
            this.lblprelist.Location = new System.Drawing.Point(248, 318);
            this.lblprelist.Name = "lblprelist";
            this.lblprelist.Size = new System.Drawing.Size(86, 20);
            this.lblprelist.TabIndex = 36;
            this.lblprelist.Text = "Pre-made :";
            this.lblprelist.Click += new System.EventHandler(this.lblprelist_Click);
            // 
            // picSandwichImage
            // 
            this.picSandwichImage.Location = new System.Drawing.Point(263, 420);
            this.picSandwichImage.Name = "picSandwichImage";
            this.picSandwichImage.Size = new System.Drawing.Size(283, 214);
            this.picSandwichImage.TabIndex = 37;
            this.picSandwichImage.TabStop = false;
            this.picSandwichImage.Click += new System.EventHandler(this.picSandwichImage_Click);
            // 
            // lblSandwichDescription
            // 
            this.lblSandwichDescription.AutoSize = true;
            this.lblSandwichDescription.Location = new System.Drawing.Point(245, 365);
            this.lblSandwichDescription.Name = "lblSandwichDescription";
            this.lblSandwichDescription.Size = new System.Drawing.Size(89, 20);
            this.lblSandwichDescription.TabIndex = 38;
            this.lblSandwichDescription.Text = "Description";
            this.lblSandwichDescription.Click += new System.EventHandler(this.lblSandwichDescription_Click);
            // 
            // lblCustomsandwich
            // 
            this.lblCustomsandwich.AutoSize = true;
            this.lblCustomsandwich.Location = new System.Drawing.Point(813, 37);
            this.lblCustomsandwich.Name = "lblCustomsandwich";
            this.lblCustomsandwich.Size = new System.Drawing.Size(196, 20);
            this.lblCustomsandwich.TabIndex = 39;
            this.lblCustomsandwich.Text = "Custom Sandwich Options";
            // 
            // lblbread
            // 
            this.lblbread.AutoSize = true;
            this.lblbread.Location = new System.Drawing.Point(771, 96);
            this.lblbread.Name = "lblbread";
            this.lblbread.Size = new System.Drawing.Size(98, 20);
            this.lblbread.TabIndex = 40;
            this.lblbread.Text = "Bread Type :";
            this.lblbread.Click += new System.EventHandler(this.lblbread_Click);
            // 
            // cboBreadType
            // 
            this.cboBreadType.FormattingEnabled = true;
            this.cboBreadType.Items.AddRange(new object[] {
            "White Bread",
            "Wheed Bread",
            "house Bread"});
            this.cboBreadType.Location = new System.Drawing.Point(886, 93);
            this.cboBreadType.Name = "cboBreadType";
            this.cboBreadType.Size = new System.Drawing.Size(135, 28);
            this.cboBreadType.TabIndex = 41;
            this.cboBreadType.SelectedIndexChanged += new System.EventHandler(this.cboBreadType_SelectedIndexChanged);
            // 
            // chkMayo
            // 
            this.chkMayo.AutoSize = true;
            this.chkMayo.Location = new System.Drawing.Point(17, 38);
            this.chkMayo.Name = "chkMayo";
            this.chkMayo.Size = new System.Drawing.Size(73, 24);
            this.chkMayo.TabIndex = 43;
            this.chkMayo.Text = "Mayo";
            this.chkMayo.UseVisualStyleBackColor = true;
            this.chkMayo.CheckedChanged += new System.EventHandler(this.chkMayo_CheckedChanged);
            // 
            // chkHoneymustrd
            // 
            this.chkHoneymustrd.AutoSize = true;
            this.chkHoneymustrd.Location = new System.Drawing.Point(17, 64);
            this.chkHoneymustrd.Name = "chkHoneymustrd";
            this.chkHoneymustrd.Size = new System.Drawing.Size(143, 24);
            this.chkHoneymustrd.TabIndex = 44;
            this.chkHoneymustrd.Text = "Honey Mustard";
            this.chkHoneymustrd.UseVisualStyleBackColor = true;
            this.chkHoneymustrd.CheckedChanged += new System.EventHandler(this.chkHoneymustrd_CheckedChanged);
            // 
            // chkRanch
            // 
            this.chkRanch.AutoSize = true;
            this.chkRanch.Location = new System.Drawing.Point(17, 90);
            this.chkRanch.Name = "chkRanch";
            this.chkRanch.Size = new System.Drawing.Size(82, 24);
            this.chkRanch.TabIndex = 45;
            this.chkRanch.Text = "Ranch";
            this.chkRanch.UseVisualStyleBackColor = true;
            this.chkRanch.CheckedChanged += new System.EventHandler(this.chkRanch_CheckedChanged);
            // 
            // chkSIgnature
            // 
            this.chkSIgnature.AutoSize = true;
            this.chkSIgnature.Location = new System.Drawing.Point(17, 120);
            this.chkSIgnature.Name = "chkSIgnature";
            this.chkSIgnature.Size = new System.Drawing.Size(104, 24);
            this.chkSIgnature.TabIndex = 46;
            this.chkSIgnature.Text = "Signature";
            this.chkSIgnature.UseVisualStyleBackColor = true;
            this.chkSIgnature.CheckedChanged += new System.EventHandler(this.chkSIgnature_CheckedChanged);
            // 
            // chkChicken
            // 
            this.chkChicken.AutoSize = true;
            this.chkChicken.Location = new System.Drawing.Point(6, 38);
            this.chkChicken.Name = "chkChicken";
            this.chkChicken.Size = new System.Drawing.Size(92, 24);
            this.chkChicken.TabIndex = 47;
            this.chkChicken.Text = "Chicken";
            this.chkChicken.UseVisualStyleBackColor = true;
            this.chkChicken.CheckedChanged += new System.EventHandler(this.chkChicken_CheckedChanged);
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Location = new System.Drawing.Point(6, 64);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(69, 24);
            this.chkHam.TabIndex = 48;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            this.chkHam.CheckedChanged += new System.EventHandler(this.chkHam_CheckedChanged);
            // 
            // chkRostBeef
            // 
            this.chkRostBeef.AutoSize = true;
            this.chkRostBeef.Location = new System.Drawing.Point(6, 90);
            this.chkRostBeef.Name = "chkRostBeef";
            this.chkRostBeef.Size = new System.Drawing.Size(116, 24);
            this.chkRostBeef.TabIndex = 49;
            this.chkRostBeef.Text = "Roast Beef";
            this.chkRostBeef.UseVisualStyleBackColor = true;
            this.chkRostBeef.CheckedChanged += new System.EventHandler(this.chkRostBeef_CheckedChanged);
            // 
            // chkBrisket
            // 
            this.chkBrisket.AutoSize = true;
            this.chkBrisket.Location = new System.Drawing.Point(6, 120);
            this.chkBrisket.Name = "chkBrisket";
            this.chkBrisket.Size = new System.Drawing.Size(84, 24);
            this.chkBrisket.TabIndex = 50;
            this.chkBrisket.Text = "Brisket";
            this.chkBrisket.UseVisualStyleBackColor = true;
            this.chkBrisket.CheckedChanged += new System.EventHandler(this.chkBrisket_CheckedChanged);
            // 
            // chlLettuce
            // 
            this.chlLettuce.AutoSize = true;
            this.chlLettuce.Location = new System.Drawing.Point(9, 34);
            this.chlLettuce.Name = "chlLettuce";
            this.chlLettuce.Size = new System.Drawing.Size(89, 24);
            this.chlLettuce.TabIndex = 53;
            this.chlLettuce.Text = "Lettuce";
            this.chlLettuce.UseVisualStyleBackColor = true;
            this.chlLettuce.CheckedChanged += new System.EventHandler(this.chlLettuce_CheckedChanged);
            // 
            // chkSweetPeppers
            // 
            this.chkSweetPeppers.AutoSize = true;
            this.chkSweetPeppers.Location = new System.Drawing.Point(9, 122);
            this.chkSweetPeppers.Name = "chkSweetPeppers";
            this.chkSweetPeppers.Size = new System.Drawing.Size(143, 24);
            this.chkSweetPeppers.TabIndex = 54;
            this.chkSweetPeppers.Text = "Sweet Peppers";
            this.chkSweetPeppers.UseVisualStyleBackColor = true;
            this.chkSweetPeppers.CheckedChanged += new System.EventHandler(this.chkSweetPeppers_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(9, 94);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(77, 24);
            this.chkOnion.TabIndex = 55;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTommato
            // 
            this.chkTommato.AutoSize = true;
            this.chkTommato.Location = new System.Drawing.Point(9, 64);
            this.chkTommato.Name = "chkTommato";
            this.chkTommato.Size = new System.Drawing.Size(102, 24);
            this.chkTommato.TabIndex = 56;
            this.chkTommato.Text = "Tommato";
            this.chkTommato.UseVisualStyleBackColor = true;
            this.chkTommato.CheckedChanged += new System.EventHandler(this.chkTommato_CheckedChanged);
            // 
            // lblTotaldisplay
            // 
            this.lblTotaldisplay.AutoSize = true;
            this.lblTotaldisplay.Location = new System.Drawing.Point(1166, 670);
            this.lblTotaldisplay.Name = "lblTotaldisplay";
            this.lblTotaldisplay.Size = new System.Drawing.Size(60, 20);
            this.lblTotaldisplay.TabIndex = 57;
            this.lblTotaldisplay.Text = "Display";
            this.lblTotaldisplay.Click += new System.EventHandler(this.lblTotaldisplay_Click);
            // 
            // grpMeat
            // 
            this.grpMeat.Controls.Add(this.chkChicken);
            this.grpMeat.Controls.Add(this.chkHam);
            this.grpMeat.Controls.Add(this.chkRostBeef);
            this.grpMeat.Controls.Add(this.chkBrisket);
            this.grpMeat.Location = new System.Drawing.Point(744, 224);
            this.grpMeat.Name = "grpMeat";
            this.grpMeat.Size = new System.Drawing.Size(135, 179);
            this.grpMeat.TabIndex = 58;
            this.grpMeat.TabStop = false;
            this.grpMeat.Text = "Meat";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(681, 485);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(8, 8);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(-111, -85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 179);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // grpTopping
            // 
            this.grpTopping.Controls.Add(this.chlLettuce);
            this.grpTopping.Controls.Add(this.chkTommato);
            this.grpTopping.Controls.Add(this.chkOnion);
            this.grpTopping.Controls.Add(this.chkSweetPeppers);
            this.grpTopping.Location = new System.Drawing.Point(886, 224);
            this.grpTopping.Name = "grpTopping";
            this.grpTopping.Size = new System.Drawing.Size(157, 164);
            this.grpTopping.TabIndex = 60;
            this.grpTopping.TabStop = false;
            this.grpTopping.Text = "Topping";
            // 
            // grpSauces
            // 
            this.grpSauces.Controls.Add(this.chkMayo);
            this.grpSauces.Controls.Add(this.chkHoneymustrd);
            this.grpSauces.Controls.Add(this.chkRanch);
            this.grpSauces.Controls.Add(this.chkSIgnature);
            this.grpSauces.Location = new System.Drawing.Point(576, 224);
            this.grpSauces.Name = "grpSauces";
            this.grpSauces.Size = new System.Drawing.Size(162, 179);
            this.grpSauces.TabIndex = 61;
            this.grpSauces.TabStop = false;
            this.grpSauces.Text = "Sauces";
            // 
            // grpPremium
            // 
            this.grpPremium.Controls.Add(this.chkextraRoastbeef);
            this.grpPremium.Controls.Add(this.chkExtraHam);
            this.grpPremium.Controls.Add(this.chkExtraChicken);
            this.grpPremium.Location = new System.Drawing.Point(1049, 224);
            this.grpPremium.Name = "grpPremium";
            this.grpPremium.Size = new System.Drawing.Size(200, 161);
            this.grpPremium.TabIndex = 62;
            this.grpPremium.TabStop = false;
            this.grpPremium.Text = "Extra";
            this.grpPremium.Enter += new System.EventHandler(this.grpPremium_Enter);
            // 
            // chkextraRoastbeef
            // 
            this.chkextraRoastbeef.AutoSize = true;
            this.chkextraRoastbeef.Location = new System.Drawing.Point(17, 86);
            this.chkextraRoastbeef.Name = "chkextraRoastbeef";
            this.chkextraRoastbeef.Size = new System.Drawing.Size(162, 24);
            this.chkextraRoastbeef.TabIndex = 2;
            this.chkextraRoastbeef.Text = "Extra - RoastBeef";
            this.chkextraRoastbeef.UseVisualStyleBackColor = true;
            this.chkextraRoastbeef.CheckedChanged += new System.EventHandler(this.chkextraRoastbeef_CheckedChanged);
            // 
            // chkExtraHam
            // 
            this.chkExtraHam.AutoSize = true;
            this.chkExtraHam.Location = new System.Drawing.Point(17, 56);
            this.chkExtraHam.Name = "chkExtraHam";
            this.chkExtraHam.Size = new System.Drawing.Size(119, 24);
            this.chkExtraHam.TabIndex = 1;
            this.chkExtraHam.Text = "Extra - Ham";
            this.chkExtraHam.UseVisualStyleBackColor = true;
            this.chkExtraHam.CheckedChanged += new System.EventHandler(this.chkExtraHam_CheckedChanged);
            // 
            // chkExtraChicken
            // 
            this.chkExtraChicken.AutoSize = true;
            this.chkExtraChicken.Location = new System.Drawing.Point(17, 26);
            this.chkExtraChicken.Name = "chkExtraChicken";
            this.chkExtraChicken.Size = new System.Drawing.Size(138, 24);
            this.chkExtraChicken.TabIndex = 0;
            this.chkExtraChicken.Text = "Extra- Chicken";
            this.chkExtraChicken.UseVisualStyleBackColor = true;
            this.chkExtraChicken.CheckedChanged += new System.EventHandler(this.chkExtraChicken_CheckedChanged);
            // 
            // lblIngafiance
            // 
            this.lblIngafiance.AutoSize = true;
            this.lblIngafiance.Location = new System.Drawing.Point(358, 365);
            this.lblIngafiance.Name = "lblIngafiance";
            this.lblIngafiance.Size = new System.Drawing.Size(81, 20);
            this.lblIngafiance.TabIndex = 63;
            this.lblIngafiance.Text = "Click Here";
            this.lblIngafiance.Click += new System.EventHandler(this.lblIngafiance_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 899);
            this.Controls.Add(this.lblIngafiance);
            this.Controls.Add(this.grpPremium);
            this.Controls.Add(this.grpSauces);
            this.Controls.Add(this.grpTopping);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpMeat);
            this.Controls.Add(this.lblTotaldisplay);
            this.Controls.Add(this.cboBreadType);
            this.Controls.Add(this.lblbread);
            this.Controls.Add(this.lblCustomsandwich);
            this.Controls.Add(this.lblSandwichDescription);
            this.Controls.Add(this.picSandwichImage);
            this.Controls.Add(this.lblprelist);
            this.Controls.Add(this.cboPreMadeSandwiches);
            this.Controls.Add(this.grpSandwichSelection);
            this.Controls.Add(this.grpDeliveryPickup);
            this.Controls.Add(this.txtTips);
            this.Controls.Add(this.lblprinttotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTips);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblCustomerinfo);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblzipcode);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblPhonenumber);
            this.Controls.Add(this.lblName);
            this.Name = "frmOrder";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.grpDeliveryPickup.ResumeLayout(false);
            this.grpDeliveryPickup.PerformLayout();
            this.grpSandwichSelection.ResumeLayout(false);
            this.grpSandwichSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSandwichImage)).EndInit();
            this.grpMeat.ResumeLayout(false);
            this.grpMeat.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grpTopping.ResumeLayout(false);
            this.grpTopping.PerformLayout();
            this.grpSauces.ResumeLayout(false);
            this.grpSauces.PerformLayout();
            this.grpPremium.ResumeLayout(false);
            this.grpPremium.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhonenumber;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblzipcode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblCustomerinfo;
        private System.Windows.Forms.RadioButton rdoPickup;
        private System.Windows.Forms.RadioButton rdoDelivery;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblTips;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblprinttotal;
        private System.Windows.Forms.TextBox txtTips;
        private System.Windows.Forms.GroupBox grpDeliveryPickup;
        private System.Windows.Forms.GroupBox grpSandwichSelection;
        private System.Windows.Forms.RadioButton rdoCustom;
        private System.Windows.Forms.RadioButton rdoPreMade;
        private System.Windows.Forms.ComboBox cboPreMadeSandwiches;
        private System.Windows.Forms.Label lblprelist;
        private System.Windows.Forms.PictureBox picSandwichImage;
        private System.Windows.Forms.Label lblSandwichDescription;
        private System.Windows.Forms.Label lblCustomsandwich;
        private System.Windows.Forms.Label lblbread;
        private System.Windows.Forms.ComboBox cboBreadType;
        private System.Windows.Forms.CheckBox chkMayo;
        private System.Windows.Forms.CheckBox chkHoneymustrd;
        private System.Windows.Forms.CheckBox chkRanch;
        private System.Windows.Forms.CheckBox chkSIgnature;
        private System.Windows.Forms.CheckBox chkChicken;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkRostBeef;
        private System.Windows.Forms.CheckBox chkBrisket;
        private System.Windows.Forms.CheckBox chlLettuce;
        private System.Windows.Forms.CheckBox chkSweetPeppers;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTommato;
        private System.Windows.Forms.Label lblTotaldisplay;
        private System.Windows.Forms.GroupBox grpMeat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpTopping;
        private System.Windows.Forms.GroupBox grpSauces;
        private System.Windows.Forms.GroupBox grpPremium;
        private System.Windows.Forms.CheckBox chkExtraChicken;
        private System.Windows.Forms.CheckBox chkextraRoastbeef;
        private System.Windows.Forms.CheckBox chkExtraHam;
        private System.Windows.Forms.Label lblIngafiance;
    }
}

