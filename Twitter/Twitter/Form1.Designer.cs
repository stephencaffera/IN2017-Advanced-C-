namespace Twitter
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
            this.Prompt = new System.Windows.Forms.Label();
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.LabelConfirmation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Prompt
            // 
            this.Prompt.AutoSize = true;
            this.Prompt.Location = new System.Drawing.Point(31, 34);
            this.Prompt.Name = "Prompt";
            this.Prompt.Size = new System.Drawing.Size(309, 25);
            this.Prompt.TabIndex = 0;
            this.Prompt.Text = "Enter your message for review:";
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Location = new System.Drawing.Point(36, 86);
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.Size = new System.Drawing.Size(579, 31);
            this.TextBoxMessage.TabIndex = 1;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(36, 146);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(162, 46);
            this.ButtonSubmit.TabIndex = 2;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // LabelConfirmation
            // 
            this.LabelConfirmation.AutoSize = true;
            this.LabelConfirmation.Location = new System.Drawing.Point(31, 223);
            this.LabelConfirmation.Name = "LabelConfirmation";
            this.LabelConfirmation.Size = new System.Drawing.Size(133, 25);
            this.LabelConfirmation.TabIndex = 3;
            this.LabelConfirmation.Text = "Confirmation";
            this.LabelConfirmation.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 300);
            this.Controls.Add(this.LabelConfirmation);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.TextBoxMessage);
            this.Controls.Add(this.Prompt);
            this.Name = "MainWindow";
            this.Text = "Twitter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Prompt;
        private System.Windows.Forms.TextBox TextBoxMessage;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.Label LabelConfirmation;
    }
}

