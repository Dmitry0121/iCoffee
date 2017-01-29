namespace CoffeeShop
{
    partial class NewOrder
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
            this.ok = new System.Windows.Forms.Button();
            this.continueShopping = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(21, 217);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 0;
            this.ok.Text = "Оформить";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // continueShopping
            // 
            this.continueShopping.Location = new System.Drawing.Point(102, 217);
            this.continueShopping.Name = "continueShopping";
            this.continueShopping.Size = new System.Drawing.Size(117, 23);
            this.continueShopping.TabIndex = 1;
            this.continueShopping.Text = "Продолжить вибор";
            this.continueShopping.UseVisualStyleBackColor = true;
            this.continueShopping.Click += new System.EventHandler(this.continueShopping_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(225, 217);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(21, 12);
            this.list.Multiline = true;
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(279, 199);
            this.list.TabIndex = 3;
            this.list.TextChanged += new System.EventHandler(this.list_TextChanged);
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 261);
            this.Controls.Add(this.list);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.continueShopping);
            this.Controls.Add(this.ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "NewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewOrder";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button continueShopping;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox list;
    }
}