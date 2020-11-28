namespace DieGuessGame
{
    partial class Form1
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
            this.rollButton = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.GameInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userGuessBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.errorBox = new System.Windows.Forms.Label();
            this.dice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dice)).BeginInit();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rollButton.FlatAppearance.BorderSize = 10;
            this.rollButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rollButton.Location = new System.Drawing.Point(217, 297);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(109, 40);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(46, 448);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(428, 125);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // GameInfo
            // 
            this.GameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameInfo.Location = new System.Drawing.Point(27, 25);
            this.GameInfo.Name = "GameInfo";
            this.GameInfo.Padding = new System.Windows.Forms.Padding(0);
            this.GameInfo.Size = new System.Drawing.Size(200, 120);
            this.GameInfo.TabIndex = 2;
            this.GameInfo.TabStop = false;
            this.GameInfo.Text = "Game Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(24, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your guess (1-6):\r\n";
            // 
            // userGuessBox
            // 
            this.userGuessBox.Location = new System.Drawing.Point(237, 234);
            this.userGuessBox.MaxLength = 1;
            this.userGuessBox.Name = "userGuessBox";
            this.userGuessBox.Size = new System.Drawing.Size(68, 22);
            this.userGuessBox.TabIndex = 4;
            // 
            // resetButton
            // 
            this.resetButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.resetButton.Location = new System.Drawing.Point(217, 362);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(109, 44);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // errorBox
            // 
            this.errorBox.AutoSize = true;
            this.errorBox.Location = new System.Drawing.Point(326, 237);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(0, 17);
            this.errorBox.TabIndex = 6;
            // 
            // dice
            // 
            this.dice.Location = new System.Drawing.Point(46, 297);
            this.dice.Name = "dice";
            this.dice.Size = new System.Drawing.Size(144, 109);
            this.dice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice.TabIndex = 7;
            this.dice.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(531, 600);
            this.Controls.Add(this.dice);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.userGuessBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GameInfo);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.rollButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Die Guessing Game";
            ((System.ComponentModel.ISupportInitialize)(this.dice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.GroupBox GameInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userGuessBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label errorBox;
        private System.Windows.Forms.PictureBox dice;
    }
}

