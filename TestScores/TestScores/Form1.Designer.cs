namespace TestScores
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
            this.LabelPrompt = new System.Windows.Forms.Label();
            this.TextBoxScores = new System.Windows.Forms.TextBox();
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.LabelResult = new System.Windows.Forms.Label();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelPrompt
            // 
            this.LabelPrompt.AutoSize = true;
            this.LabelPrompt.Location = new System.Drawing.Point(40, 32);
            this.LabelPrompt.Name = "LabelPrompt";
            this.LabelPrompt.Size = new System.Drawing.Size(187, 25);
            this.LabelPrompt.TabIndex = 0;
            this.LabelPrompt.Text = "Enter a test score:";
            // 
            // TextBoxScores
            // 
            this.TextBoxScores.Location = new System.Drawing.Point(45, 82);
            this.TextBoxScores.Name = "TextBoxScores";
            this.TextBoxScores.Size = new System.Drawing.Size(226, 31);
            this.TextBoxScores.TabIndex = 1;
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.Location = new System.Drawing.Point(383, 32);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(181, 81);
            this.ButtonEnter.TabIndex = 2;
            this.ButtonEnter.Text = "Enter";
            this.ButtonEnter.UseVisualStyleBackColor = true;
            this.ButtonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(40, 143);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(73, 25);
            this.LabelResult.TabIndex = 4;
            this.LabelResult.Text = "Result";
            this.LabelResult.Visible = false;
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(383, 143);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(181, 80);
            this.ButtonCalculate.TabIndex = 5;
            this.ButtonCalculate.Text = "Calculate";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 264);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.TextBoxScores);
            this.Controls.Add(this.LabelPrompt);
            this.Name = "MainWindow";
            this.Text = "Test Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPrompt;
        private System.Windows.Forms.TextBox TextBoxScores;
        private System.Windows.Forms.Button ButtonEnter;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.Button ButtonCalculate;
    }
}

