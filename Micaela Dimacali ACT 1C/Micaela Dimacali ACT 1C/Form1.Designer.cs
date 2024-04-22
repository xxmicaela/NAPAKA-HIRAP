namespace Micaela_Dimacali_ACT_1C
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            btnSignIn = new Button();
            chbShowPassword = new CheckBox();
            label4 = new Label();
            LinkSignUp = new LinkLabel();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(20, 22);
            label1.Name = "label1";
            label1.Size = new Size(83, 30);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(163, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(106, 143);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(109, 173);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = " Enter your username";
            txtUsername.Size = new Size(202, 32);
            txtUsername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(109, 218);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(109, 247);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = " Enter your password";
            txtPassword.Size = new Size(202, 32);
            txtPassword.TabIndex = 5;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.Blue;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.GhostWhite;
            btnSignIn.Location = new Point(150, 324);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(126, 34);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbShowPassword.Location = new Point(109, 285);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(118, 21);
            chbShowPassword.TabIndex = 7;
            chbShowPassword.Text = "Show Password";
            chbShowPassword.UseVisualStyleBackColor = true;
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(94, 375);
            label4.Name = "label4";
            label4.Size = new Size(156, 17);
            label4.TabIndex = 8;
            label4.Text = "Don't have an account ?";
            // 
            // LinkSignUp
            // 
            LinkSignUp.AutoSize = true;
            LinkSignUp.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            LinkSignUp.Location = new Point(249, 375);
            LinkSignUp.Name = "LinkSignUp";
            LinkSignUp.Size = new Size(62, 19);
            LinkSignUp.TabIndex = 9;
            LinkSignUp.TabStop = true;
            LinkSignUp.Text = "Sign Up";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(146, 420);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 30);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 563);
            Controls.Add(btnClose);
            Controls.Add(LinkSignUp);
            Controls.Add(label4);
            Controls.Add(chbShowPassword);
            Controls.Add(btnSignIn);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        private Button btnSignIn;
        private CheckBox chbShowPassword;
        private Label label4;
        private LinkLabel LinkSignUp;
        private Button btnClose;
    }
}
