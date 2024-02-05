
namespace Hangman
{
    partial class Hangman
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
            this.letterInput = new System.Windows.Forms.TextBox();
            this.hangmanPicture = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.letterGuessButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.wordInput = new System.Windows.Forms.TextBox();
            this.wordGuessButton = new System.Windows.Forms.Button();
            this.realWordLabel = new System.Windows.Forms.Label();
            this.winOrLoseLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lettersGuessed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // letterInput
            // 
            this.letterInput.Enabled = false;
            this.letterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.letterInput.Location = new System.Drawing.Point(86, 299);
            this.letterInput.MaxLength = 1;
            this.letterInput.Name = "letterInput";
            this.letterInput.Size = new System.Drawing.Size(61, 30);
            this.letterInput.TabIndex = 0;
            this.letterInput.TextChanged += new System.EventHandler(this.letterInput_TextChanged);
            // 
            // hangmanPicture
            // 
            this.hangmanPicture.Image = global::Hangman.Properties.Resources.Base;
            this.hangmanPicture.Location = new System.Drawing.Point(257, 131);
            this.hangmanPicture.Name = "hangmanPicture";
            this.hangmanPicture.Size = new System.Drawing.Size(573, 501);
            this.hangmanPicture.TabIndex = 1;
            this.hangmanPicture.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.startButton.Location = new System.Drawing.Point(890, 290);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(133, 48);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Enabled = false;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.resetButton.Location = new System.Drawing.Point(890, 483);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(133, 48);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset Game";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(48, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Guess a letter:";
            // 
            // letterGuessButton
            // 
            this.letterGuessButton.Enabled = false;
            this.letterGuessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.letterGuessButton.Location = new System.Drawing.Point(53, 335);
            this.letterGuessButton.Name = "letterGuessButton";
            this.letterGuessButton.Size = new System.Drawing.Size(133, 48);
            this.letterGuessButton.TabIndex = 6;
            this.letterGuessButton.Text = "Guess Letter";
            this.letterGuessButton.UseVisualStyleBackColor = true;
            this.letterGuessButton.Click += new System.EventHandler(this.letterGuessButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(42, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Guess the word:";
            // 
            // wordInput
            // 
            this.wordInput.Enabled = false;
            this.wordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.wordInput.Location = new System.Drawing.Point(29, 483);
            this.wordInput.MaxLength = 1;
            this.wordInput.Name = "wordInput";
            this.wordInput.Size = new System.Drawing.Size(191, 30);
            this.wordInput.TabIndex = 8;
            this.wordInput.TextChanged += new System.EventHandler(this.wordInput_TextChanged);
            // 
            // wordGuessButton
            // 
            this.wordGuessButton.Enabled = false;
            this.wordGuessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.wordGuessButton.Location = new System.Drawing.Point(55, 521);
            this.wordGuessButton.Name = "wordGuessButton";
            this.wordGuessButton.Size = new System.Drawing.Size(133, 48);
            this.wordGuessButton.TabIndex = 9;
            this.wordGuessButton.Text = "Guess Word";
            this.wordGuessButton.UseVisualStyleBackColor = true;
            this.wordGuessButton.Click += new System.EventHandler(this.wordGuessButton_Click);
            // 
            // realWordLabel
            // 
            this.realWordLabel.AutoSize = true;
            this.realWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.realWordLabel.Location = new System.Drawing.Point(505, 75);
            this.realWordLabel.Name = "realWordLabel";
            this.realWordLabel.Size = new System.Drawing.Size(109, 36);
            this.realWordLabel.TabIndex = 10;
            this.realWordLabel.Text = "WORD";
            this.realWordLabel.Visible = false;
            // 
            // winOrLoseLabel
            // 
            this.winOrLoseLabel.AutoSize = true;
            this.winOrLoseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.winOrLoseLabel.Location = new System.Drawing.Point(488, 28);
            this.winOrLoseLabel.Name = "winOrLoseLabel";
            this.winOrLoseLabel.Size = new System.Drawing.Size(138, 36);
            this.winOrLoseLabel.TabIndex = 11;
            this.winOrLoseLabel.Text = "You Win!";
            this.winOrLoseLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(42, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Guess a letter:";
            // 
            // lettersGuessed
            // 
            this.lettersGuessed.AutoSize = true;
            this.lettersGuessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lettersGuessed.Location = new System.Drawing.Point(12, 75);
            this.lettersGuessed.Name = "lettersGuessed";
            this.lettersGuessed.Size = new System.Drawing.Size(0, 25);
            this.lettersGuessed.TabIndex = 13;
            this.lettersGuessed.Visible = false;
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 644);
            this.Controls.Add(this.lettersGuessed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.winOrLoseLabel);
            this.Controls.Add(this.realWordLabel);
            this.Controls.Add(this.wordGuessButton);
            this.Controls.Add(this.wordInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.letterGuessButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.hangmanPicture);
            this.Controls.Add(this.letterInput);
            this.Name = "Hangman";
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox letterInput;
        private System.Windows.Forms.PictureBox hangmanPicture;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button letterGuessButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wordInput;
        private System.Windows.Forms.Button wordGuessButton;
        private System.Windows.Forms.Label realWordLabel;
        private System.Windows.Forms.Label winOrLoseLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lettersGuessed;
    }
}

