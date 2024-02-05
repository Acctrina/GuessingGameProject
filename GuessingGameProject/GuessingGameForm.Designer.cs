namespace GuessingGameProject
{
    partial class GuessingGameForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.numTriesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numberTrackBar = new System.Windows.Forms.TrackBar();
            this.numberLabel = new System.Windows.Forms.Label();
            this.guessesLeftBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numberTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(416, 55);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(89, 39);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(436, 188);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(69, 35);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(294, 139);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 32);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // numTriesLabel
            // 
            this.numTriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numTriesLabel.Location = new System.Drawing.Point(416, 139);
            this.numTriesLabel.Name = "numTriesLabel";
            this.numTriesLabel.Size = new System.Drawing.Size(87, 32);
            this.numTriesLabel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "No. of Tries";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 57);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number Guessing Game (0 - 100) (Max. 8 Tries/Per Game)";
            // 
            // messageLabel
            // 
            this.messageLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.messageLabel.Location = new System.Drawing.Point(75, 232);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(161, 71);
            this.messageLabel.TabIndex = 7;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(394, 9);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(42, 17);
            this.userLabel.TabIndex = 8;
            this.userLabel.Text = "User:";
            this.userLabel.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(442, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 23);
            this.nameLabel.TabIndex = 9;
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(365, 269);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(197, 34);
            this.dateLabel.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numberTrackBar
            // 
            this.numberTrackBar.Location = new System.Drawing.Point(59, 95);
            this.numberTrackBar.Maximum = 100;
            this.numberTrackBar.Name = "numberTrackBar";
            this.numberTrackBar.Size = new System.Drawing.Size(229, 56);
            this.numberTrackBar.TabIndex = 11;
            this.numberTrackBar.Scroll += new System.EventHandler(this.numberTrackBar_Scroll);
            // 
            // numberLabel
            // 
            this.numberLabel.BackColor = System.Drawing.Color.White;
            this.numberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(152, 137);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(69, 34);
            this.numberLabel.TabIndex = 12;
            this.numberLabel.Text = "0";
            // 
            // guessesLeftBar
            // 
            this.guessesLeftBar.Location = new System.Drawing.Point(69, 188);
            this.guessesLeftBar.Name = "guessesLeftBar";
            this.guessesLeftBar.Size = new System.Drawing.Size(210, 23);
            this.guessesLeftBar.TabIndex = 13;
            // 
            // GuessingGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 312);
            this.Controls.Add(this.guessesLeftBar);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.numberTrackBar);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTriesLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Name = "GuessingGameForm";
            this.Text = "GuessingGameForm";
            this.Load += new System.EventHandler(this.GuessingGameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label numTriesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar numberTrackBar;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.ProgressBar guessesLeftBar;
    }
}