namespace SumInts
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
            this.TextBoxNumber = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelPrompt
            // 
            this.LabelPrompt.AutoSize = true;
            this.LabelPrompt.Location = new System.Drawing.Point(44, 42);
            this.LabelPrompt.Name = "LabelPrompt";
            this.LabelPrompt.Size = new System.Drawing.Size(356, 25);
            this.LabelPrompt.TabIndex = 0;
            this.LabelPrompt.Text = "Enter an integer to add to your total:";
            // 
            // TextBoxNumber
            // 
            this.TextBoxNumber.Location = new System.Drawing.Point(49, 96);
            this.TextBoxNumber.Name = "TextBoxNumber";
            this.TextBoxNumber.Size = new System.Drawing.Size(169, 31);
            this.TextBoxNumber.TabIndex = 1;
            this.TextBoxNumber.Text = "0";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(241, 83);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(159, 56);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Location = new System.Drawing.Point(44, 161);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(60, 25);
            this.LabelTotal.TabIndex = 3;
            this.LabelTotal.Text = "Total";
            this.LabelTotal.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 229);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextBoxNumber);
            this.Controls.Add(this.LabelPrompt);
            this.Name = "MainWindow";
            this.Text = "Add Integers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPrompt;
        private System.Windows.Forms.TextBox TextBoxNumber;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label LabelTotal;
    }
}

