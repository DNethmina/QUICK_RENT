namespace CW_Finel_App1
{
    partial class Feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feedback));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFeedback = new System.Windows.Forms.TextBox();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.buttonCn = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxFT = new System.Windows.Forms.PictureBox();
            this.labelFT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feedback";
            // 
            // textBoxFeedback
            // 
            this.textBoxFeedback.BackColor = System.Drawing.Color.White;
            this.textBoxFeedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFeedback.ForeColor = System.Drawing.Color.Black;
            this.textBoxFeedback.Location = new System.Drawing.Point(33, 101);
            this.textBoxFeedback.Multiline = true;
            this.textBoxFeedback.Name = "textBoxFeedback";
            this.textBoxFeedback.Size = new System.Drawing.Size(769, 305);
            this.textBoxFeedback.TabIndex = 1;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.FlatAppearance.BorderSize = 2;
            this.ButtonSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.ButtonSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.ButtonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSubmit.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonSubmit.Location = new System.Drawing.Point(463, 441);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(91, 39);
            this.ButtonSubmit.TabIndex = 2;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // buttonCn
            // 
            this.buttonCn.FlatAppearance.BorderSize = 2;
            this.buttonCn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.buttonCn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonCn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCn.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonCn.Location = new System.Drawing.Point(584, 441);
            this.buttonCn.Name = "buttonCn";
            this.buttonCn.Size = new System.Drawing.Size(91, 39);
            this.buttonCn.TabIndex = 3;
            this.buttonCn.Text = "Clear";
            this.buttonCn.UseVisualStyleBackColor = true;
            this.buttonCn.Click += new System.EventHandler(this.buttonCn_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.FlatAppearance.BorderSize = 2;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonBack.Location = new System.Drawing.Point(711, 441);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(91, 39);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFT
            // 
            this.pictureBoxFT.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFT.Image")));
            this.pictureBoxFT.Location = new System.Drawing.Point(157, 464);
            this.pictureBoxFT.Name = "pictureBoxFT";
            this.pictureBoxFT.Size = new System.Drawing.Size(35, 33);
            this.pictureBoxFT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFT.TabIndex = 20;
            this.pictureBoxFT.TabStop = false;
            // 
            // labelFT
            // 
            this.labelFT.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelFT.AutoSize = true;
            this.labelFT.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFT.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelFT.Location = new System.Drawing.Point(13, 463);
            this.labelFT.Name = "labelFT";
            this.labelFT.Size = new System.Drawing.Size(138, 34);
            this.labelFT.TabIndex = 19;
            this.labelFT.Text = "Quick Rent";
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(826, 506);
            this.Controls.Add(this.pictureBoxFT);
            this.Controls.Add(this.labelFT);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCn);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.textBoxFeedback);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Feedback";
            this.Text = "Feedback";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFeedback;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.Button buttonCn;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxFT;
        private System.Windows.Forms.Label labelFT;
    }
}