namespace CW_Finel_App1
{
    partial class Vehicale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicale));
            this.labelV = new System.Windows.Forms.Label();
            this.labelVID = new System.Windows.Forms.Label();
            this.labelVB = new System.Windows.Forms.Label();
            this.labelVT = new System.Windows.Forms.Label();
            this.labelEN = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.textBoxNo = new System.Windows.Forms.TextBox();
            this.buttonVS = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.dataGridViewvehical = new System.Windows.Forms.DataGridView();
            this.vehicalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.final_DBDataSet = new CW_Finel_App1.Final_DBDataSet();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.textBoxVno = new System.Windows.Forms.TextBox();
            this.labelVno = new System.Windows.Forms.Label();
            this.vehicalTableAdapter = new CW_Finel_App1.Final_DBDataSetTableAdapters.VehicalTableAdapter();
            this.errorProviderVid = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderVB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderVT = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEn = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderVn = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBoxVDT = new System.Windows.Forms.PictureBox();
            this.labelVDT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewvehical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.final_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVDT)).BeginInit();
            this.SuspendLayout();
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelV.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelV.Location = new System.Drawing.Point(13, 28);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(263, 40);
            this.labelV.TabIndex = 0;
            this.labelV.Text = "Vehicale Detail\'s";
            // 
            // labelVID
            // 
            this.labelVID.AutoSize = true;
            this.labelVID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVID.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelVID.Location = new System.Drawing.Point(20, 147);
            this.labelVID.Name = "labelVID";
            this.labelVID.Size = new System.Drawing.Size(78, 16);
            this.labelVID.TabIndex = 1;
            this.labelVID.Text = "Vehical ID";
            // 
            // labelVB
            // 
            this.labelVB.AutoSize = true;
            this.labelVB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVB.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelVB.Location = new System.Drawing.Point(20, 204);
            this.labelVB.Name = "labelVB";
            this.labelVB.Size = new System.Drawing.Size(104, 16);
            this.labelVB.TabIndex = 2;
            this.labelVB.Text = "Vehical Brand";
            // 
            // labelVT
            // 
            this.labelVT.AutoSize = true;
            this.labelVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVT.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelVT.Location = new System.Drawing.Point(20, 259);
            this.labelVT.Name = "labelVT";
            this.labelVT.Size = new System.Drawing.Size(99, 16);
            this.labelVT.TabIndex = 3;
            this.labelVT.Text = "Vehical Type";
            // 
            // labelEN
            // 
            this.labelEN.AutoSize = true;
            this.labelEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEN.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelEN.Location = new System.Drawing.Point(20, 315);
            this.labelEN.Name = "labelEN";
            this.labelEN.Size = new System.Drawing.Size(83, 16);
            this.labelEN.TabIndex = 4;
            this.labelEN.Text = "Engine_No";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxID.ForeColor = System.Drawing.Color.Black;
            this.textBoxID.Location = new System.Drawing.Point(156, 140);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(236, 22);
            this.textBoxID.TabIndex = 5;
            // 
            // textBoxB
            // 
            this.textBoxB.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxB.ForeColor = System.Drawing.Color.Black;
            this.textBoxB.Location = new System.Drawing.Point(156, 198);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(236, 22);
            this.textBoxB.TabIndex = 6;
            // 
            // textBoxT
            // 
            this.textBoxT.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxT.ForeColor = System.Drawing.Color.Black;
            this.textBoxT.Location = new System.Drawing.Point(156, 253);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(236, 22);
            this.textBoxT.TabIndex = 7;
            // 
            // textBoxNo
            // 
            this.textBoxNo.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNo.ForeColor = System.Drawing.Color.Black;
            this.textBoxNo.Location = new System.Drawing.Point(156, 309);
            this.textBoxNo.Name = "textBoxNo";
            this.textBoxNo.Size = new System.Drawing.Size(236, 22);
            this.textBoxNo.TabIndex = 8;
            // 
            // buttonVS
            // 
            this.buttonVS.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.buttonVS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.buttonVS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.buttonVS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVS.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonVS.Location = new System.Drawing.Point(156, 420);
            this.buttonVS.Name = "buttonVS";
            this.buttonVS.Size = new System.Drawing.Size(104, 33);
            this.buttonVS.TabIndex = 9;
            this.buttonVS.Text = "Add";
            this.buttonVS.UseVisualStyleBackColor = true;
            this.buttonVS.Click += new System.EventHandler(this.buttonVS_Click);
            // 
            // buttonC
            // 
            this.buttonC.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.buttonC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.buttonC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonC.Location = new System.Drawing.Point(288, 420);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(104, 33);
            this.buttonC.TabIndex = 10;
            this.buttonC.Text = "Clear";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // dataGridViewvehical
            // 
            this.dataGridViewvehical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewvehical.Location = new System.Drawing.Point(482, 140);
            this.dataGridViewvehical.Name = "dataGridViewvehical";
            this.dataGridViewvehical.RowHeadersWidth = 51;
            this.dataGridViewvehical.RowTemplate.Height = 24;
            this.dataGridViewvehical.Size = new System.Drawing.Size(889, 286);
            this.dataGridViewvehical.TabIndex = 11;
            this.dataGridViewvehical.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewvehical_CellClick);
            // 
            // vehicalBindingSource
            // 
            this.vehicalBindingSource.DataMember = "Vehical";
            this.vehicalBindingSource.DataSource = this.final_DBDataSet;
            // 
            // final_DBDataSet
            // 
            this.final_DBDataSet.DataSetName = "Final_DBDataSet";
            this.final_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonD
            // 
            this.buttonD.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.buttonD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.buttonD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.buttonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonD.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonD.Location = new System.Drawing.Point(156, 479);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(104, 35);
            this.buttonD.TabIndex = 12;
            this.buttonD.Text = "Delete";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonS
            // 
            this.buttonS.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.buttonS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.buttonS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.buttonS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonS.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonS.Location = new System.Drawing.Point(288, 479);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(104, 35);
            this.buttonS.TabIndex = 13;
            this.buttonS.Text = "Search";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // textBoxVno
            // 
            this.textBoxVno.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxVno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVno.ForeColor = System.Drawing.Color.Black;
            this.textBoxVno.Location = new System.Drawing.Point(156, 353);
            this.textBoxVno.Name = "textBoxVno";
            this.textBoxVno.Size = new System.Drawing.Size(236, 22);
            this.textBoxVno.TabIndex = 15;
            // 
            // labelVno
            // 
            this.labelVno.AutoSize = true;
            this.labelVno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVno.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelVno.Location = new System.Drawing.Point(20, 359);
            this.labelVno.Name = "labelVno";
            this.labelVno.Size = new System.Drawing.Size(87, 16);
            this.labelVno.TabIndex = 14;
            this.labelVno.Text = "Vehical_No";
            // 
            // vehicalTableAdapter
            // 
            this.vehicalTableAdapter.ClearBeforeFill = true;
            // 
            // errorProviderVid
            // 
            this.errorProviderVid.ContainerControl = this;
            // 
            // errorProviderVB
            // 
            this.errorProviderVB.ContainerControl = this;
            // 
            // errorProviderVT
            // 
            this.errorProviderVT.ContainerControl = this;
            // 
            // errorProviderEn
            // 
            this.errorProviderEn.ContainerControl = this;
            // 
            // errorProviderVn
            // 
            this.errorProviderVn.ContainerControl = this;
            // 
            // pictureBoxVDT
            // 
            this.pictureBoxVDT.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVDT.Image")));
            this.pictureBoxVDT.Location = new System.Drawing.Point(1336, 484);
            this.pictureBoxVDT.Name = "pictureBoxVDT";
            this.pictureBoxVDT.Size = new System.Drawing.Size(35, 33);
            this.pictureBoxVDT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVDT.TabIndex = 20;
            this.pictureBoxVDT.TabStop = false;
            // 
            // labelVDT
            // 
            this.labelVDT.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelVDT.AutoSize = true;
            this.labelVDT.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVDT.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelVDT.Location = new System.Drawing.Point(1192, 483);
            this.labelVDT.Name = "labelVDT";
            this.labelVDT.Size = new System.Drawing.Size(138, 34);
            this.labelVDT.TabIndex = 19;
            this.labelVDT.Text = "Quick Rent";
            // 
            // Vehicale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1383, 527);
            this.Controls.Add(this.pictureBoxVDT);
            this.Controls.Add(this.labelVDT);
            this.Controls.Add(this.textBoxVno);
            this.Controls.Add(this.labelVno);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.dataGridViewvehical);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonVS);
            this.Controls.Add(this.textBoxNo);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelEN);
            this.Controls.Add(this.labelVT);
            this.Controls.Add(this.labelVB);
            this.Controls.Add(this.labelVID);
            this.Controls.Add(this.labelV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Vehicale";
            this.Text = "Vehicale";
            this.Load += new System.EventHandler(this.Vehicale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewvehical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.final_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.Label labelVID;
        private System.Windows.Forms.Label labelVB;
        private System.Windows.Forms.Label labelVT;
        private System.Windows.Forms.Label labelEN;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.TextBox textBoxNo;
        private System.Windows.Forms.Button buttonVS;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.DataGridView dataGridViewvehical;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.TextBox textBoxVno;
        private System.Windows.Forms.Label labelVno;
        private Final_DBDataSet final_DBDataSet;
        private System.Windows.Forms.BindingSource vehicalBindingSource;
        private Final_DBDataSetTableAdapters.VehicalTableAdapter vehicalTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProviderVid;
        private System.Windows.Forms.ErrorProvider errorProviderVB;
        private System.Windows.Forms.ErrorProvider errorProviderVT;
        private System.Windows.Forms.ErrorProvider errorProviderEn;
        private System.Windows.Forms.ErrorProvider errorProviderVn;
        private System.Windows.Forms.PictureBox pictureBoxVDT;
        private System.Windows.Forms.Label labelVDT;
    }
}