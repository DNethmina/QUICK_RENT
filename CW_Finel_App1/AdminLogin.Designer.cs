namespace CW_Finel_App1
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxL = new System.Windows.Forms.PictureBox();
            this.textAdminpassword = new System.Windows.Forms.TextBox();
            this.textAdminUser = new System.Windows.Forms.TextBox();
            this.labelAdminPassword = new System.Windows.Forms.Label();
            this.labelAdminUser = new System.Windows.Forms.Label();
            this.labelAdminlogin = new System.Windows.Forms.Label();
            this.pictureBoxG = new System.Windows.Forms.PictureBox();
            this.errorProviderUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBoxALT = new System.Windows.Forms.PictureBox();
            this.labelALT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxALT)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.SeaGreen;
            this.button2.Location = new System.Drawing.Point(669, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 47);
            this.button2.TabIndex = 15;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.SeaGreen;
            this.button1.Location = new System.Drawing.Point(506, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 47);
            this.button1.TabIndex = 14;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxL
            // 
            this.pictureBoxL.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxL.Image")));
            this.pictureBoxL.Location = new System.Drawing.Point(510, 40);
            this.pictureBoxL.Name = "pictureBoxL";
            this.pictureBoxL.Size = new System.Drawing.Size(142, 120);
            this.pictureBoxL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxL.TabIndex = 13;
            this.pictureBoxL.TabStop = false;
            // 
            // textAdminpassword
            // 
            this.textAdminpassword.BackColor = System.Drawing.Color.Honeydew;
            this.textAdminpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAdminpassword.ForeColor = System.Drawing.Color.Black;
            this.textAdminpassword.Location = new System.Drawing.Point(389, 299);
            this.textAdminpassword.Name = "textAdminpassword";
            this.textAdminpassword.PasswordChar = '*';
            this.textAdminpassword.Size = new System.Drawing.Size(409, 24);
            this.textAdminpassword.TabIndex = 12;
            // 
            // textAdminUser
            // 
            this.textAdminUser.BackColor = System.Drawing.Color.Honeydew;
            this.textAdminUser.ForeColor = System.Drawing.Color.Black;
            this.textAdminUser.Location = new System.Drawing.Point(389, 225);
            this.textAdminUser.Name = "textAdminUser";
            this.textAdminUser.Size = new System.Drawing.Size(409, 22);
            this.textAdminUser.TabIndex = 11;
            // 
            // labelAdminPassword
            // 
            this.labelAdminPassword.AutoSize = true;
            this.labelAdminPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminPassword.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelAdminPassword.Location = new System.Drawing.Point(271, 297);
            this.labelAdminPassword.Name = "labelAdminPassword";
            this.labelAdminPassword.Size = new System.Drawing.Size(86, 23);
            this.labelAdminPassword.TabIndex = 10;
            this.labelAdminPassword.Text = "Password";
            // 
            // labelAdminUser
            // 
            this.labelAdminUser.AutoSize = true;
            this.labelAdminUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminUser.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelAdminUser.Location = new System.Drawing.Point(287, 223);
            this.labelAdminUser.Name = "labelAdminUser";
            this.labelAdminUser.Size = new System.Drawing.Size(70, 23);
            this.labelAdminUser.TabIndex = 9;
            this.labelAdminUser.Text = "User ID";
            // 
            // labelAdminlogin
            // 
            this.labelAdminlogin.AutoSize = true;
            this.labelAdminlogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminlogin.Location = new System.Drawing.Point(3, 8);
            this.labelAdminlogin.Name = "labelAdminlogin";
            this.labelAdminlogin.Size = new System.Drawing.Size(232, 44);
            this.labelAdminlogin.TabIndex = 18;
            this.labelAdminlogin.Text = "Admin Login";
            // 
            // pictureBoxG
            // 
            this.pictureBoxG.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxG.Image")));
            this.pictureBoxG.Location = new System.Drawing.Point(0, 72);
            this.pictureBoxG.Name = "pictureBoxG";
            this.pictureBoxG.Size = new System.Drawing.Size(215, 364);
            this.pictureBoxG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxG.TabIndex = 19;
            this.pictureBoxG.TabStop = false;
            // 
            // errorProviderUser
            // 
            this.errorProviderUser.ContainerControl = this;
            // 
            // errorProviderPass
            // 
            this.errorProviderPass.ContainerControl = this;
            // 
            // pictureBoxALT
            // 
            this.pictureBoxALT.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxALT.Image")));
            this.pictureBoxALT.Location = new System.Drawing.Point(149, 395);
            this.pictureBoxALT.Name = "pictureBoxALT";
            this.pictureBoxALT.Size = new System.Drawing.Size(35, 33);
            this.pictureBoxALT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxALT.TabIndex = 21;
            this.pictureBoxALT.TabStop = false;
            // 
            // labelALT
            // 
            this.labelALT.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelALT.AutoSize = true;
            this.labelALT.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelALT.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelALT.Location = new System.Drawing.Point(5, 394);
            this.labelALT.Name = "labelALT";
            this.labelALT.Size = new System.Drawing.Size(138, 34);
            this.labelALT.TabIndex = 20;
            this.labelALT.Text = "Quick Rent";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(865, 437);
            this.Controls.Add(this.pictureBoxALT);
            this.Controls.Add(this.labelALT);
            this.Controls.Add(this.pictureBoxG);
            this.Controls.Add(this.labelAdminlogin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxL);
            this.Controls.Add(this.textAdminpassword);
            this.Controls.Add(this.textAdminUser);
            this.Controls.Add(this.labelAdminPassword);
            this.Controls.Add(this.labelAdminUser);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
           
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxALT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxL;
        private System.Windows.Forms.TextBox textAdminpassword;
        private System.Windows.Forms.TextBox textAdminUser;
        private System.Windows.Forms.Label labelAdminPassword;
        private System.Windows.Forms.Label labelAdminUser;
        private System.Windows.Forms.Label labelAdminlogin;
        private System.Windows.Forms.PictureBox pictureBoxG;
        private System.Windows.Forms.ErrorProvider errorProviderUser;
        private System.Windows.Forms.ErrorProvider errorProviderPass;
        private System.Windows.Forms.PictureBox pictureBoxALT;
        private System.Windows.Forms.Label labelALT;
    }
}