namespace CW_Finel_App1
{
    partial class CustomerF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerF));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCF = new System.Windows.Forms.TextBox();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.pictureBoxCFT = new System.Windows.Forms.PictureBox();
            this.labelCFT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCFT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Feedback\'s";
            // 
            // textBoxCF
            // 
            this.textBoxCF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCF.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCF.ForeColor = System.Drawing.Color.Black;
            this.textBoxCF.Location = new System.Drawing.Point(34, 95);
            this.textBoxCF.Multiline = true;
            this.textBoxCF.Name = "textBoxCF";
            this.textBoxCF.Size = new System.Drawing.Size(640, 389);
            this.textBoxCF.TabIndex = 1;
            // 
            // buttonR
            // 
            this.buttonR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonR.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonR.Location = new System.Drawing.Point(395, 502);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(75, 29);
            this.buttonR.TabIndex = 2;
            this.buttonR.Text = "Read";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // buttonW
            // 
            this.buttonW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonW.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonW.Location = new System.Drawing.Point(497, 502);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(75, 29);
            this.buttonW.TabIndex = 3;
            this.buttonW.Text = "Write";
            this.buttonW.UseVisualStyleBackColor = true;
            this.buttonW.Click += new System.EventHandler(this.buttonW_Click);
            // 
            // buttonC
            // 
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(599, 502);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(75, 29);
            this.buttonC.TabIndex = 4;
            this.buttonC.Text = "Clear";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // pictureBoxCFT
            // 
            this.pictureBoxCFT.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCFT.Image")));
            this.pictureBoxCFT.Location = new System.Drawing.Point(151, 521);
            this.pictureBoxCFT.Name = "pictureBoxCFT";
            this.pictureBoxCFT.Size = new System.Drawing.Size(35, 33);
            this.pictureBoxCFT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCFT.TabIndex = 20;
            this.pictureBoxCFT.TabStop = false;
            // 
            // labelCFT
            // 
            this.labelCFT.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelCFT.AutoSize = true;
            this.labelCFT.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCFT.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelCFT.Location = new System.Drawing.Point(7, 520);
            this.labelCFT.Name = "labelCFT";
            this.labelCFT.Size = new System.Drawing.Size(138, 34);
            this.labelCFT.TabIndex = 19;
            this.labelCFT.Text = "Quick Rent";
            // 
            // CustomerF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 44F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(727, 563);
            this.Controls.Add(this.pictureBoxCFT);
            this.Controls.Add(this.labelCFT);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonW);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.textBoxCF);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "CustomerF";
            this.Text = "CustomerF";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCFT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCF;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.PictureBox pictureBoxCFT;
        private System.Windows.Forms.Label labelCFT;
    }
}