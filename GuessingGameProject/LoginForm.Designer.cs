namespace GuessingGameProject
{
    partial class LoginForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.QuitButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.AcceptsReturn = true;
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nameTextBox.Location = new System.Drawing.Point(73, 109);
            this.nameTextBox.MaxLength = 12;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameTextBox.Size = new System.Drawing.Size(115, 20);
            this.nameTextBox.TabIndex = 27;
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lblPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassword.Location = new System.Drawing.Point(10, 153);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPassword.Size = new System.Drawing.Size(65, 15);
            this.lblPassword.TabIndex = 26;
            this.lblPassword.Text = "Password:";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.Control;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(17, 109);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(65, 15);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "User ID:";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.Control;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoginButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginButton.Location = new System.Drawing.Point(198, 107);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginButton.Size = new System.Drawing.Size(73, 25);
            this.LoginButton.TabIndex = 29;
            this.LoginButton.Text = "&Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(20, 222);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(190, 32);
            this.RegistrationButton.TabIndex = 32;
            this.RegistrationButton.Text = "Register for New user";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(43, 36);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(210, 24);
            this.Label1.TabIndex = 24;
            this.Label1.Text = "Guessing Game Login";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AcceptsReturn = true;
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.passwordTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.passwordTextBox.Location = new System.Drawing.Point(76, 151);
            this.passwordTextBox.MaxLength = 12;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordTextBox.Size = new System.Drawing.Size(115, 20);
            this.passwordTextBox.TabIndex = 28;
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.SystemColors.Control;
            this.QuitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.QuitButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.QuitButton.Location = new System.Drawing.Point(198, 150);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QuitButton.Size = new System.Drawing.Size(73, 25);
            this.QuitButton.TabIndex = 30;
            this.QuitButton.Text = "&Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(219, 225);
            this.logButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(56, 25);
            this.logButton.TabIndex = 33;
            this.logButton.Text = "Log";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 278);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.QuitButton);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.Label lblPassword;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Button LoginButton;
        public System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.Button RegistrationButton;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.TextBox passwordTextBox;
        public System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button logButton;
    }
}

