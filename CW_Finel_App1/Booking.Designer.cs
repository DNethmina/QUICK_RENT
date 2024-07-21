namespace CW_Finel_App1
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.labelCBID = new System.Windows.Forms.Label();
            this.textBoxBCID = new System.Windows.Forms.TextBox();
            this.textBoxVID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBS = new System.Windows.Forms.Button();
            this.buttonBD = new System.Windows.Forms.Button();
            this.buttonBC = new System.Windows.Forms.Button();
            this.buttonBVS = new System.Windows.Forms.Button();
            this.labelBTitale = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelprice = new System.Windows.Forms.Label();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.buttoncal = new System.Windows.Forms.Button();
            this.textBoxKm = new System.Windows.Forms.TextBox();
            this.labelKm = new System.Windows.Forms.Label();
            this.cW_Final2DataSet = new CW_Finel_App1.CW_Final2DataSet();
            this.cWFinal2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cW_Final2DataSet1 = new CW_Finel_App1.CW_Final2DataSet1();
            this.bookingTableAdapter = new CW_Finel_App1.CW_Final2DataSet1TableAdapters.BookingTableAdapter();
            this.dataGridViewB = new System.Windows.Forms.DataGridView();
            this.bookingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.final_DBDataSet = new CW_Finel_App1.Final_DBDataSet();
            this.bookingTableAdapter1 = new CW_Finel_App1.Final_DBDataSetTableAdapters.BookingTableAdapter();
            this.errorProviderBCID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderBVID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDes = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderkm = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBoxVBT = new System.Windows.Forms.PictureBox();
            this.labelVBT = new System.Windows.Forms.Label();
            this.errorProviderPrice = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cW_Final2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cWFinal2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cW_Final2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.final_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBCID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBVID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderkm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCBID
            // 
            this.labelCBID.AutoSize = true;
            this.labelCBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCBID.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelCBID.Location = new System.Drawing.Point(12, 123);
            this.labelCBID.Name = "labelCBID";
            this.labelCBID.Size = new System.Drawing.Size(95, 16);
            this.labelCBID.TabIndex = 0;
            this.labelCBID.Text = "Customer_ID";
            // 
            // textBoxBCID
            // 
            this.textBoxBCID.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBCID.ForeColor = System.Drawing.Color.Black;
            this.textBoxBCID.Location = new System.Drawing.Point(143, 116);
            this.textBoxBCID.Name = "textBoxBCID";
            this.textBoxBCID.Size = new System.Drawing.Size(282, 22);
            this.textBoxBCID.TabIndex = 1;
            // 
            // textBoxVID
            // 
            this.textBoxVID.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxVID.ForeColor = System.Drawing.Color.Black;
            this.textBoxVID.Location = new System.Drawing.Point(143, 177);
            this.textBoxVID.Name = "textBoxVID";
            this.textBoxVID.Size = new System.Drawing.Size(282, 22);
            this.textBoxVID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(12, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vehical_ID";
            // 
            // buttonBS
            // 
            this.buttonBS.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.buttonBS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.buttonBS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.buttonBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBS.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonBS.Location = new System.Drawing.Point(321, 498);
            this.buttonBS.Name = "buttonBS";
            this.buttonBS.Size = new System.Drawing.Size(104, 31);
            this.buttonBS.TabIndex = 17;
            this.buttonBS.Text = "Search";
            this.buttonBS.UseVisualStyleBackColor = true;
            this.buttonBS.Click += new System.EventHandler(this.buttonBS_Click);
            // 
            // buttonBD
            // 
            this.buttonBD.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.buttonBD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.buttonBD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.buttonBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBD.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonBD.Location = new System.Drawing.Point(183, 498);
            this.buttonBD.Name = "buttonBD";
            this.buttonBD.Size = new System.Drawing.Size(104, 31);
            this.buttonBD.TabIndex = 16;
            this.buttonBD.Text = "Delete";
            this.buttonBD.UseVisualStyleBackColor = true;
            this.buttonBD.Click += new System.EventHandler(this.buttonBD_Click);
            // 
            // buttonBC
            // 
            this.buttonBC.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.buttonBC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.buttonBC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.buttonBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBC.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonBC.Location = new System.Drawing.Point(183, 449);
            this.buttonBC.Name = "buttonBC";
            this.buttonBC.Size = new System.Drawing.Size(104, 33);
            this.buttonBC.TabIndex = 15;
            this.buttonBC.Text = "Clear";
            this.buttonBC.UseVisualStyleBackColor = true;
            this.buttonBC.Click += new System.EventHandler(this.buttonBC_Click);
            // 
            // buttonBVS
            // 
            this.buttonBVS.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.buttonBVS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.buttonBVS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.buttonBVS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBVS.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonBVS.Location = new System.Drawing.Point(321, 449);
            this.buttonBVS.Name = "buttonBVS";
            this.buttonBVS.Size = new System.Drawing.Size(104, 33);
            this.buttonBVS.TabIndex = 14;
            this.buttonBVS.Text = "Add";
            this.buttonBVS.UseVisualStyleBackColor = true;
            this.buttonBVS.Click += new System.EventHandler(this.buttonBVS_Click);
            // 
            // labelBTitale
            // 
            this.labelBTitale.AutoSize = true;
            this.labelBTitale.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBTitale.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelBTitale.Location = new System.Drawing.Point(11, 27);
            this.labelBTitale.Name = "labelBTitale";
            this.labelBTitale.Size = new System.Drawing.Size(247, 37);
            this.labelBTitale.TabIndex = 19;
            this.labelBTitale.Text = "Vehical_Booking";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxPrice.ForeColor = System.Drawing.Color.Black;
            this.textBoxPrice.Location = new System.Drawing.Point(143, 250);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(150, 22);
            this.textBoxPrice.TabIndex = 21;
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprice.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelprice.Location = new System.Drawing.Point(12, 257);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(43, 16);
            this.labelprice.TabIndex = 20;
            this.labelprice.Text = "Price";
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxDestination.ForeColor = System.Drawing.Color.Black;
            this.textBoxDestination.Location = new System.Drawing.Point(143, 313);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(282, 22);
            this.textBoxDestination.TabIndex = 23;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestination.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelDestination.Location = new System.Drawing.Point(12, 320);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(85, 16);
            this.labelDestination.TabIndex = 22;
            this.labelDestination.Text = "Destination";
            // 
            // buttoncal
            // 
            this.buttoncal.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.buttoncal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.buttoncal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.buttoncal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncal.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttoncal.Location = new System.Drawing.Point(321, 236);
            this.buttoncal.Name = "buttoncal";
            this.buttoncal.Size = new System.Drawing.Size(104, 36);
            this.buttoncal.TabIndex = 24;
            this.buttoncal.Text = "Calculater";
            this.buttoncal.UseVisualStyleBackColor = true;
            this.buttoncal.Click += new System.EventHandler(this.buttoncal_Click);
            // 
            // textBoxKm
            // 
            this.textBoxKm.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxKm.ForeColor = System.Drawing.Color.Black;
            this.textBoxKm.Location = new System.Drawing.Point(143, 378);
            this.textBoxKm.Name = "textBoxKm";
            this.textBoxKm.Size = new System.Drawing.Size(282, 22);
            this.textBoxKm.TabIndex = 26;
            // 
            // labelKm
            // 
            this.labelKm.AutoSize = true;
            this.labelKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKm.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelKm.Location = new System.Drawing.Point(12, 385);
            this.labelKm.Name = "labelKm";
            this.labelKm.Size = new System.Drawing.Size(68, 16);
            this.labelKm.TabIndex = 25;
            this.labelKm.Text = "No 0f KM";
            // 
            // cW_Final2DataSet
            // 
            this.cW_Final2DataSet.DataSetName = "CW_Final2DataSet";
            this.cW_Final2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cWFinal2DataSetBindingSource
            // 
            this.cWFinal2DataSetBindingSource.DataSource = this.cW_Final2DataSet;
            this.cWFinal2DataSetBindingSource.Position = 0;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.cW_Final2DataSet1;
            // 
            // cW_Final2DataSet1
            // 
            this.cW_Final2DataSet1.DataSetName = "CW_Final2DataSet1";
            this.cW_Final2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewB
            // 
            this.dataGridViewB.AllowUserToOrderColumns = true;
            this.dataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewB.Location = new System.Drawing.Point(459, 116);
            this.dataGridViewB.Name = "dataGridViewB";
            this.dataGridViewB.RowHeadersWidth = 51;
            this.dataGridViewB.RowTemplate.Height = 24;
            this.dataGridViewB.Size = new System.Drawing.Size(897, 413);
            this.dataGridViewB.TabIndex = 27;
            this.dataGridViewB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bookingBindingSource1
            // 
            this.bookingBindingSource1.DataMember = "Booking";
            this.bookingBindingSource1.DataSource = this.final_DBDataSet;
            // 
            // final_DBDataSet
            // 
            this.final_DBDataSet.DataSetName = "Final_DBDataSet";
            this.final_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingTableAdapter1
            // 
            this.bookingTableAdapter1.ClearBeforeFill = true;
            // 
            // errorProviderBCID
            // 
            this.errorProviderBCID.ContainerControl = this;
            // 
            // errorProviderBVID
            // 
            this.errorProviderBVID.ContainerControl = this;
            // 
            // errorProviderDes
            // 
            this.errorProviderDes.ContainerControl = this;
            // 
            // errorProviderkm
            // 
            this.errorProviderkm.ContainerControl = this;
            // 
            // pictureBoxVBT
            // 
            this.pictureBoxVBT.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVBT.Image")));
            this.pictureBoxVBT.Location = new System.Drawing.Point(153, 560);
            this.pictureBoxVBT.Name = "pictureBoxVBT";
            this.pictureBoxVBT.Size = new System.Drawing.Size(35, 33);
            this.pictureBoxVBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVBT.TabIndex = 29;
            this.pictureBoxVBT.TabStop = false;
            // 
            // labelVBT
            // 
            this.labelVBT.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelVBT.AutoSize = true;
            this.labelVBT.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVBT.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelVBT.Location = new System.Drawing.Point(9, 559);
            this.labelVBT.Name = "labelVBT";
            this.labelVBT.Size = new System.Drawing.Size(138, 34);
            this.labelVBT.TabIndex = 28;
            this.labelVBT.Text = "Quick Rent";
            // 
            // errorProviderPrice
            // 
            this.errorProviderPrice.ContainerControl = this;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1392, 611);
            this.Controls.Add(this.pictureBoxVBT);
            this.Controls.Add(this.labelVBT);
            this.Controls.Add(this.dataGridViewB);
            this.Controls.Add(this.textBoxKm);
            this.Controls.Add(this.labelKm);
            this.Controls.Add(this.buttoncal);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelprice);
            this.Controls.Add(this.labelBTitale);
            this.Controls.Add(this.buttonBS);
            this.Controls.Add(this.buttonBD);
            this.Controls.Add(this.buttonBC);
            this.Controls.Add(this.buttonBVS);
            this.Controls.Add(this.textBoxVID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBCID);
            this.Controls.Add(this.labelCBID);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cW_Final2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cWFinal2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cW_Final2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.final_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBCID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBVID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderkm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCBID;
        private System.Windows.Forms.TextBox textBoxBCID;
        private System.Windows.Forms.TextBox textBoxVID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBS;
        private System.Windows.Forms.Button buttonBD;
        private System.Windows.Forms.Button buttonBC;
        private System.Windows.Forms.Button buttonBVS;
        private System.Windows.Forms.Label labelBTitale;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Button buttoncal;
        private System.Windows.Forms.TextBox textBoxKm;
        private System.Windows.Forms.Label labelKm;
        private CW_Final2DataSet cW_Final2DataSet;
        private System.Windows.Forms.BindingSource cWFinal2DataSetBindingSource;
        private CW_Final2DataSet1 cW_Final2DataSet1;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private CW_Final2DataSet1TableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewB;
        private Final_DBDataSet final_DBDataSet;
        private System.Windows.Forms.BindingSource bookingBindingSource1;
        private Final_DBDataSetTableAdapters.BookingTableAdapter bookingTableAdapter1;
        private System.Windows.Forms.ErrorProvider errorProviderBCID;
        private System.Windows.Forms.ErrorProvider errorProviderBVID;
        private System.Windows.Forms.ErrorProvider errorProviderDes;
        private System.Windows.Forms.ErrorProvider errorProviderkm;
        private System.Windows.Forms.PictureBox pictureBoxVBT;
        private System.Windows.Forms.Label labelVBT;
        private System.Windows.Forms.ErrorProvider errorProviderPrice;
    }
}