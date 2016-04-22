namespace GuessingGame {
    partial class GuessingGameForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.SelectNumberLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ClickToSeeButton = new System.Windows.Forms.Button();
            this.SorryIwasThinkingLabel = new System.Windows.Forms.Label();
            this.CorrectGuessesLabel = new System.Windows.Forms.Label();
            this.IncorrectGuessesLabel = new System.Windows.Forms.Label();
            this.CorrectGuessesTextBox = new System.Windows.Forms.TextBox();
            this.IncorrectGuessesTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectNumberLabel
            // 
            this.SelectNumberLabel.AutoSize = true;
            this.SelectNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SelectNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.SelectNumberLabel.Location = new System.Drawing.Point(251, 80);
            this.SelectNumberLabel.Name = "SelectNumberLabel";
            this.SelectNumberLabel.Size = new System.Drawing.Size(142, 22);
            this.SelectNumberLabel.TabIndex = 0;
            this.SelectNumberLabel.Text = "Select a number";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(420, 79);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 23);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ClickToSeeButton
            // 
            this.ClickToSeeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClickToSeeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClickToSeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickToSeeButton.Location = new System.Drawing.Point(295, 133);
            this.ClickToSeeButton.Name = "ClickToSeeButton";
            this.ClickToSeeButton.Size = new System.Drawing.Size(176, 79);
            this.ClickToSeeButton.TabIndex = 2;
            this.ClickToSeeButton.Text = "Click to see if you have guessed my number";
            this.ClickToSeeButton.UseVisualStyleBackColor = false;
            // 
            // SorryIwasThinkingLabel
            // 
            this.SorryIwasThinkingLabel.AutoSize = true;
            this.SorryIwasThinkingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SorryIwasThinkingLabel.Location = new System.Drawing.Point(247, 246);
            this.SorryIwasThinkingLabel.Name = "SorryIwasThinkingLabel";
            this.SorryIwasThinkingLabel.Size = new System.Drawing.Size(163, 20);
            this.SorryIwasThinkingLabel.TabIndex = 3;
            this.SorryIwasThinkingLabel.Text = "Sorry I was think of";
            // 
            // CorrectGuessesLabel
            // 
            this.CorrectGuessesLabel.AutoSize = true;
            this.CorrectGuessesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectGuessesLabel.Location = new System.Drawing.Point(180, 290);
            this.CorrectGuessesLabel.Name = "CorrectGuessesLabel";
            this.CorrectGuessesLabel.Size = new System.Drawing.Size(144, 20);
            this.CorrectGuessesLabel.TabIndex = 4;
            this.CorrectGuessesLabel.Text = "Correct Guesses";
            // 
            // IncorrectGuessesLabel
            // 
            this.IncorrectGuessesLabel.AutoSize = true;
            this.IncorrectGuessesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncorrectGuessesLabel.Location = new System.Drawing.Point(416, 290);
            this.IncorrectGuessesLabel.Name = "IncorrectGuessesLabel";
            this.IncorrectGuessesLabel.Size = new System.Drawing.Size(151, 20);
            this.IncorrectGuessesLabel.TabIndex = 5;
            this.IncorrectGuessesLabel.Text = "Incorect Guesses";
            // 
            // CorrectGuessesTextBox
            // 
            this.CorrectGuessesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectGuessesTextBox.Location = new System.Drawing.Point(330, 290);
            this.CorrectGuessesTextBox.Name = "CorrectGuessesTextBox";
            this.CorrectGuessesTextBox.Size = new System.Drawing.Size(27, 23);
            this.CorrectGuessesTextBox.TabIndex = 6;
            // 
            // IncorrectGuessesTextBox
            // 
            this.IncorrectGuessesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncorrectGuessesTextBox.Location = new System.Drawing.Point(573, 290);
            this.IncorrectGuessesTextBox.Name = "IncorrectGuessesTextBox";
            this.IncorrectGuessesTextBox.Size = new System.Drawing.Size(26, 23);
            this.IncorrectGuessesTextBox.TabIndex = 7;
            // 
            // GuessingGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 467);
            this.Controls.Add(this.IncorrectGuessesTextBox);
            this.Controls.Add(this.CorrectGuessesTextBox);
            this.Controls.Add(this.IncorrectGuessesLabel);
            this.Controls.Add(this.CorrectGuessesLabel);
            this.Controls.Add(this.SorryIwasThinkingLabel);
            this.Controls.Add(this.ClickToSeeButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.SelectNumberLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "GuessingGameForm";
            this.Text = "GuessingGameForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectNumberLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button ClickToSeeButton;
        private System.Windows.Forms.Label SorryIwasThinkingLabel;
        private System.Windows.Forms.Label CorrectGuessesLabel;
        private System.Windows.Forms.Label IncorrectGuessesLabel;
        private System.Windows.Forms.TextBox CorrectGuessesTextBox;
        private System.Windows.Forms.TextBox IncorrectGuessesTextBox;
    }
}

