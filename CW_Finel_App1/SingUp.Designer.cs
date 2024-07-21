namespace CW_Finel_App1
{
    partial class SingUp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingUp));
            this.labelName = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelNIC = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.LabelAge = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labeltitale = new System.Windows.Forms.Label();
            this.textBoxCID = new System.Windows.Forms.TextBox();
            this.customerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cW_Final2DataSet = new CW_Finel_App1.CW_Final2DataSet();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textNIC = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textContact = new System.Windows.Forms.TextBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.buttonSClear = new System.Windows.Forms.Button();
            this.buttonSSave = new System.Windows.Forms.Button();
            this.labelCID = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.customer_DetailsTableAdapter = new CW_Finel_App1.CW_Final2DataSetTableAdapters.Customer_DetailsTableAdapter();
            this.errorProviderCID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNIC = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAge = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContact = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBoxCRT = new System.Windows.Forms.PictureBox();
            this.labelCRT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cW_Final2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCRT)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(34, 122);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Full Name";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(34, 175);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(52, 16);
            this.labelCountry.TabIndex = 1;
            this.labelCountry.Text = "Country";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(34, 235);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(58, 16);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address";
            // 
            // labelNIC
            // 
            this.labelNIC.AutoSize = true;
            this.labelNIC.Location = new System.Drawing.Point(34, 292);
            this.labelNIC.Name = "labelNIC";
            this.labelNIC.Size = new System.Drawing.Size(102, 32);
            this.labelNIC.TabIndex = 3;
            this.labelNIC.Text = "Youe NIC No Or\r\nPassport No";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(34, 354);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(52, 16);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Gender";
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.Location = new System.Drawing.Point(34, 424);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(32, 16);
            this.LabelAge.TabIndex = 5;
            this.LabelAge.Text = "Age";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(34, 487);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(103, 16);
            this.labelContact.TabIndex = 6;
            this.labelContact.Text = "Contact Number";
            // 
            // labeltitale
            // 
            this.labeltitale.AutoSize = true;
            this.labeltitale.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitale.Location = new System.Drawing.Point(10, 4);
            this.labeltitale.Name = "labeltitale";
            this.labeltitale.Size = new System.Drawing.Size(150, 44);
            this.labeltitale.TabIndex = 8;
            this.labeltitale.Text = "Sing Up";
            // 
            // textBoxCID
            // 
            this.textBoxCID.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxCID.ForeColor = System.Drawing.Color.Black;
            this.textBoxCID.Location = new System.Drawing.Point(210, 84);
            this.textBoxCID.Multiline = true;
            this.textBoxCID.Name = "textBoxCID";
            this.textBoxCID.Size = new System.Drawing.Size(316, 22);
            this.textBoxCID.TabIndex = 10;
            // 
            // customerDetailsBindingSource
            // 
            this.customerDetailsBindingSource.DataMember = "Customer_Details";
            this.customerDetailsBindingSource.DataSource = this.cW_Final2DataSet;
            // 
            // cW_Final2DataSet
            // 
            this.cW_Final2DataSet.DataSetName = "CW_Final2DataSet";
            this.cW_Final2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxAddress.ForeColor = System.Drawing.Color.Black;
            this.textBoxAddress.Location = new System.Drawing.Point(210, 232);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(316, 22);
            this.textBoxAddress.TabIndex = 12;
            // 
            // textNIC
            // 
            this.textNIC.BackColor = System.Drawing.Color.Honeydew;
            this.textNIC.ForeColor = System.Drawing.Color.Black;
            this.textNIC.Location = new System.Drawing.Point(210, 292);
            this.textNIC.Name = "textNIC";
            this.textNIC.Size = new System.Drawing.Size(316, 22);
            this.textNIC.TabIndex = 13;
            // 
            // textAge
            // 
            this.textAge.BackColor = System.Drawing.Color.Honeydew;
            this.textAge.ForeColor = System.Drawing.Color.Black;
            this.textAge.Location = new System.Drawing.Point(209, 418);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(316, 22);
            this.textAge.TabIndex = 15;
            // 
            // textContact
            // 
            this.textContact.BackColor = System.Drawing.Color.Honeydew;
            this.textContact.ForeColor = System.Drawing.Color.Black;
            this.textContact.Location = new System.Drawing.Point(209, 481);
            this.textContact.Name = "textContact";
            this.textContact.Size = new System.Drawing.Size(316, 22);
            this.textContact.TabIndex = 16;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(210, 349);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(58, 20);
            this.radioButtonMale.TabIndex = 21;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(312, 348);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(74, 20);
            this.radioButtonFemale.TabIndex = 22;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // buttonSClear
            // 
            this.buttonSClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.buttonSClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonSClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSClear.Location = new System.Drawing.Point(321, 537);
            this.buttonSClear.Name = "buttonSClear";
            this.buttonSClear.Size = new System.Drawing.Size(98, 38);
            this.buttonSClear.TabIndex = 23;
            this.buttonSClear.Text = "Clear";
            this.buttonSClear.UseVisualStyleBackColor = true;
            this.buttonSClear.Click += new System.EventHandler(this.buttonSClear_Click);
            // 
            // buttonSSave
            // 
            this.buttonSSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.buttonSSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonSSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSSave.Location = new System.Drawing.Point(437, 537);
            this.buttonSSave.Name = "buttonSSave";
            this.buttonSSave.Size = new System.Drawing.Size(88, 38);
            this.buttonSSave.TabIndex = 24;
            this.buttonSSave.Text = "Save";
            this.buttonSSave.UseVisualStyleBackColor = true;
            this.buttonSSave.Click += new System.EventHandler(this.buttonSSave_Click);
            // 
            // labelCID
            // 
            this.labelCID.AutoSize = true;
            this.labelCID.Location = new System.Drawing.Point(34, 84);
            this.labelCID.Name = "labelCID";
            this.labelCID.Size = new System.Drawing.Size(80, 16);
            this.labelCID.TabIndex = 25;
            this.labelCID.Text = "Customer ID";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxName.ForeColor = System.Drawing.Color.Black;
            this.textBoxName.Location = new System.Drawing.Point(209, 122);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(316, 22);
            this.textBoxName.TabIndex = 26;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.BackColor = System.Drawing.Color.Honeydew;
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCountry.ForeColor = System.Drawing.Color.Black;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Items.AddRange(new object[] {
            "Sri Lanka",
            "Indea",
            "America",
            "Japan",
            "Chaina",
            "Russia",
            "Ukreain",
            "German",
            "Dubai",
            "Korea"});
            this.comboBoxCountry.Location = new System.Drawing.Point(210, 175);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(316, 24);
            this.comboBoxCountry.TabIndex = 27;
            // 
            // customer_DetailsTableAdapter
            // 
            this.customer_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // errorProviderCID
            // 
            this.errorProviderCID.ContainerControl = this;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderNIC
            // 
            this.errorProviderNIC.ContainerControl = this;
            // 
            // errorProviderAddress
            // 
            this.errorProviderAddress.ContainerControl = this;
            // 
            // errorProviderAge
            // 
            this.errorProviderAge.ContainerControl = this;
            // 
            // errorProviderContact
            // 
            this.errorProviderContact.ContainerControl = this;
            // 
            // pictureBoxCRT
            // 
            this.pictureBoxCRT.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCRT.Image")));
            this.pictureBoxCRT.Location = new System.Drawing.Point(156, 563);
            this.pictureBoxCRT.Name = "pictureBoxCRT";
            this.pictureBoxCRT.Size = new System.Drawing.Size(35, 33);
            this.pictureBoxCRT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCRT.TabIndex = 29;
            this.pictureBoxCRT.TabStop = false;
            // 
            // labelCRT
            // 
            this.labelCRT.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelCRT.AutoSize = true;
            this.labelCRT.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCRT.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelCRT.Location = new System.Drawing.Point(12, 562);
            this.labelCRT.Name = "labelCRT";
            this.labelCRT.Size = new System.Drawing.Size(138, 34);
            this.labelCRT.TabIndex = 28;
            this.labelCRT.Text = "Quick Rent";
            // 
            // SingUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(568, 605);
            this.Controls.Add(this.pictureBoxCRT);
            this.Controls.Add(this.labelCRT);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelCID);
            this.Controls.Add(this.buttonSSave);
            this.Controls.Add(this.buttonSClear);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.textContact);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textNIC);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxCID);
            this.Controls.Add(this.labeltitale);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.LabelAge);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelNIC);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelName);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SingUp";
            this.Text = "SingUp";
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cW_Final2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCRT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelNIC;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label LabelAge;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labeltitale;
        private System.Windows.Forms.TextBox textBoxCID;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textNIC;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textContact;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Button buttonSClear;
        private System.Windows.Forms.Button buttonSSave;
        private System.Windows.Forms.Label labelCID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private CW_Final2DataSet cW_Final2DataSet;
        private System.Windows.Forms.BindingSource customerDetailsBindingSource;
        private CW_Final2DataSetTableAdapters.Customer_DetailsTableAdapter customer_DetailsTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProviderCID;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderNIC;
        private System.Windows.Forms.ErrorProvider errorProviderAddress;
        private System.Windows.Forms.ErrorProvider errorProviderAge;
        private System.Windows.Forms.ErrorProvider errorProviderContact;
        private System.Windows.Forms.PictureBox pictureBoxCRT;
        private System.Windows.Forms.Label labelCRT;
    }
}