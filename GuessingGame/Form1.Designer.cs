namespace GuessingGame
{
    partial class MainWindow
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
            this.ButtonGuess = new System.Windows.Forms.Button();
            this.LabelPrompt = new System.Windows.Forms.Label();
            this.TextBoxGuess = new System.Windows.Forms.TextBox();
            this.LabelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonGuess
            // 
            this.ButtonGuess.Location = new System.Drawing.Point(360, 78);
            this.ButtonGuess.Name = "ButtonGuess";
            this.ButtonGuess.Size = new System.Drawing.Size(209, 65);
            this.ButtonGuess.TabIndex = 0;
            this.ButtonGuess.Text = "Guess";
            this.ButtonGuess.UseVisualStyleBackColor = true;
            this.ButtonGuess.Click += new System.EventHandler(this.ButtonGuess_Click);
            // 
            // LabelPrompt
            // 
            this.LabelPrompt.AutoSize = true;
            this.LabelPrompt.Location = new System.Drawing.Point(45, 46);
            this.LabelPrompt.Name = "LabelPrompt";
            this.LabelPrompt.Size = new System.Drawing.Size(244, 25);
            this.LabelPrompt.TabIndex = 1;
            this.LabelPrompt.Text = "Enter your guess (1-10):";
            // 
            // TextBoxGuess
            // 
            this.TextBoxGuess.Location = new System.Drawing.Point(45, 112);
            this.TextBoxGuess.Name = "TextBoxGuess";
            this.TextBoxGuess.Size = new System.Drawing.Size(239, 31);
            this.TextBoxGuess.TabIndex = 2;
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(45, 184);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(73, 25);
            this.LabelResult.TabIndex = 3;
            this.LabelResult.Text = "Result";
            this.LabelResult.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 344);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.TextBoxGuess);
            this.Controls.Add(this.ButtonGuess);
            this.Controls.Add(this.LabelPrompt);
            this.Name = "MainWindow";
            this.Text = "Number Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonGuess;
        private System.Windows.Forms.Label LabelPrompt;
        private System.Windows.Forms.TextBox TextBoxGuess;
        private System.Windows.Forms.Label LabelResult;
    }
}

