namespace MarshallsRevenueGUI
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
            this.Header = new System.Windows.Forms.Label();
            this.LabelExterior = new System.Windows.Forms.Label();
            this.LabelInterior = new System.Windows.Forms.Label();
            this.TextBoxExterior = new System.Windows.Forms.TextBox();
            this.TextBoxInterior = new System.Windows.Forms.TextBox();
            this.ButtonOrder = new System.Windows.Forms.Button();
            this.OrderHeader = new System.Windows.Forms.Label();
            this.LabelOrderExterior = new System.Windows.Forms.Label();
            this.LabelOrderInterior = new System.Windows.Forms.Label();
            this.LabelOrderTotal = new System.Windows.Forms.Label();
            this.LabelMonth = new System.Windows.Forms.Label();
            this.TextBoxMonth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Location = new System.Drawing.Point(57, 47);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(641, 25);
            this.Header.TabIndex = 0;
            this.Header.Text = "Please enter the number of murals of each type you wish to order:";
            // 
            // LabelExterior
            // 
            this.LabelExterior.AutoSize = true;
            this.LabelExterior.Location = new System.Drawing.Point(57, 112);
            this.LabelExterior.Name = "LabelExterior";
            this.LabelExterior.Size = new System.Drawing.Size(162, 25);
            this.LabelExterior.TabIndex = 1;
            this.LabelExterior.Text = "Exterior murals:";
            // 
            // LabelInterior
            // 
            this.LabelInterior.AutoSize = true;
            this.LabelInterior.Location = new System.Drawing.Point(57, 173);
            this.LabelInterior.Name = "LabelInterior";
            this.LabelInterior.Size = new System.Drawing.Size(154, 25);
            this.LabelInterior.TabIndex = 2;
            this.LabelInterior.Text = "Interior murals:";
            // 
            // TextBoxExterior
            // 
            this.TextBoxExterior.Location = new System.Drawing.Point(258, 109);
            this.TextBoxExterior.Name = "TextBoxExterior";
            this.TextBoxExterior.Size = new System.Drawing.Size(243, 31);
            this.TextBoxExterior.TabIndex = 3;
            this.TextBoxExterior.Text = "0";
            // 
            // TextBoxInterior
            // 
            this.TextBoxInterior.Location = new System.Drawing.Point(258, 170);
            this.TextBoxInterior.Name = "TextBoxInterior";
            this.TextBoxInterior.Size = new System.Drawing.Size(243, 31);
            this.TextBoxInterior.TabIndex = 4;
            this.TextBoxInterior.Text = "0";
            // 
            // ButtonOrder
            // 
            this.ButtonOrder.Location = new System.Drawing.Point(556, 141);
            this.ButtonOrder.Name = "ButtonOrder";
            this.ButtonOrder.Size = new System.Drawing.Size(234, 89);
            this.ButtonOrder.TabIndex = 5;
            this.ButtonOrder.Text = "Submit";
            this.ButtonOrder.UseVisualStyleBackColor = true;
            this.ButtonOrder.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // OrderHeader
            // 
            this.OrderHeader.AutoSize = true;
            this.OrderHeader.Location = new System.Drawing.Point(57, 349);
            this.OrderHeader.Name = "OrderHeader";
            this.OrderHeader.Size = new System.Drawing.Size(144, 25);
            this.OrderHeader.TabIndex = 6;
            this.OrderHeader.Text = "Order Details:";
            // 
            // LabelOrderExterior
            // 
            this.LabelOrderExterior.AutoSize = true;
            this.LabelOrderExterior.Location = new System.Drawing.Point(97, 411);
            this.LabelOrderExterior.Name = "LabelOrderExterior";
            this.LabelOrderExterior.Size = new System.Drawing.Size(162, 25);
            this.LabelOrderExterior.TabIndex = 7;
            this.LabelOrderExterior.Text = "Exterior murals:";
            this.LabelOrderExterior.Visible = false;
            // 
            // LabelOrderInterior
            // 
            this.LabelOrderInterior.AutoSize = true;
            this.LabelOrderInterior.Location = new System.Drawing.Point(97, 470);
            this.LabelOrderInterior.Name = "LabelOrderInterior";
            this.LabelOrderInterior.Size = new System.Drawing.Size(154, 25);
            this.LabelOrderInterior.TabIndex = 8;
            this.LabelOrderInterior.Text = "Interior murals:";
            this.LabelOrderInterior.Visible = false;
            // 
            // LabelOrderTotal
            // 
            this.LabelOrderTotal.AutoSize = true;
            this.LabelOrderTotal.Location = new System.Drawing.Point(97, 531);
            this.LabelOrderTotal.Name = "LabelOrderTotal";
            this.LabelOrderTotal.Size = new System.Drawing.Size(136, 25);
            this.LabelOrderTotal.TabIndex = 9;
            this.LabelOrderTotal.Text = "Total murals:";
            this.LabelOrderTotal.Visible = false;
            // 
            // LabelMonth
            // 
            this.LabelMonth.AutoSize = true;
            this.LabelMonth.Location = new System.Drawing.Point(57, 241);
            this.LabelMonth.Name = "LabelMonth";
            this.LabelMonth.Size = new System.Drawing.Size(78, 25);
            this.LabelMonth.TabIndex = 10;
            this.LabelMonth.Text = "Month:";
            // 
            // TextBoxMonth
            // 
            this.TextBoxMonth.Location = new System.Drawing.Point(165, 238);
            this.TextBoxMonth.Name = "TextBoxMonth";
            this.TextBoxMonth.Size = new System.Drawing.Size(115, 31);
            this.TextBoxMonth.TabIndex = 11;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 613);
            this.Controls.Add(this.TextBoxMonth);
            this.Controls.Add(this.LabelMonth);
            this.Controls.Add(this.LabelOrderTotal);
            this.Controls.Add(this.LabelOrderInterior);
            this.Controls.Add(this.LabelOrderExterior);
            this.Controls.Add(this.OrderHeader);
            this.Controls.Add(this.ButtonOrder);
            this.Controls.Add(this.TextBoxInterior);
            this.Controls.Add(this.TextBoxExterior);
            this.Controls.Add(this.LabelInterior);
            this.Controls.Add(this.LabelExterior);
            this.Controls.Add(this.Header);
            this.Name = "MainWindow";
            this.Text = "Marshalls Revenue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label LabelExterior;
        private System.Windows.Forms.Label LabelInterior;
        private System.Windows.Forms.TextBox TextBoxExterior;
        private System.Windows.Forms.TextBox TextBoxInterior;
        private System.Windows.Forms.Button ButtonOrder;
        private System.Windows.Forms.Label OrderHeader;
        private System.Windows.Forms.Label LabelOrderExterior;
        private System.Windows.Forms.Label LabelOrderInterior;
        private System.Windows.Forms.Label LabelOrderTotal;
        private System.Windows.Forms.Label LabelMonth;
        private System.Windows.Forms.TextBox TextBoxMonth;
    }
}

