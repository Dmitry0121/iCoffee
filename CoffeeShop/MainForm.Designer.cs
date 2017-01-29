namespace CoffeeShop
{
    partial class MainForm
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
            this.newOrder = new System.Windows.Forms.Button();
            this.espressoAddCup = new System.Windows.Forms.Button();
            this.espressoCount = new System.Windows.Forms.TextBox();
            this.espressoDelCup = new System.Windows.Forms.Button();
            this.choiceEspresso = new System.Windows.Forms.CheckBox();
            this.cappuccinoAddCup = new System.Windows.Forms.Button();
            this.cappuccinoDelCup = new System.Windows.Forms.Button();
            this.cappuccinoCount = new System.Windows.Forms.TextBox();
            this.choiceCappuccino = new System.Windows.Forms.CheckBox();
            this.americanoAddCup = new System.Windows.Forms.Button();
            this.americanoDelCup = new System.Windows.Forms.Button();
            this.americanoCount = new System.Windows.Forms.TextBox();
            this.choiceAmericano = new System.Windows.Forms.CheckBox();
            this.latteAddCup = new System.Windows.Forms.Button();
            this.latteDelCup = new System.Windows.Forms.Button();
            this.latteCount = new System.Windows.Forms.TextBox();
            this.choiceLatte = new System.Windows.Forms.CheckBox();
            this.latte = new System.Windows.Forms.PictureBox();
            this.americano = new System.Windows.Forms.PictureBox();
            this.cappuccino = new System.Windows.Forms.PictureBox();
            this.espresso = new System.Windows.Forms.PictureBox();
            this.about = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.latte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.americano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cappuccino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espresso)).BeginInit();
            this.SuspendLayout();
            // 
            // newOrder
            // 
            this.newOrder.Location = new System.Drawing.Point(24, 311);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(521, 41);
            this.newOrder.TabIndex = 1;
            this.newOrder.Text = "Оформить заказ";
            this.newOrder.UseVisualStyleBackColor = true;
            this.newOrder.Click += new System.EventHandler(this.newOrder_Click);
            // 
            // espressoAddCup
            // 
            this.espressoAddCup.Location = new System.Drawing.Point(95, 117);
            this.espressoAddCup.Name = "espressoAddCup";
            this.espressoAddCup.Size = new System.Drawing.Size(31, 23);
            this.espressoAddCup.TabIndex = 9;
            this.espressoAddCup.Text = "+";
            this.espressoAddCup.UseVisualStyleBackColor = true;
            this.espressoAddCup.Click += new System.EventHandler(this.espressoAddCup_Click);
            // 
            // espressoCount
            // 
            this.espressoCount.Location = new System.Drawing.Point(61, 117);
            this.espressoCount.Name = "espressoCount";
            this.espressoCount.Size = new System.Drawing.Size(28, 20);
            this.espressoCount.TabIndex = 11;
            // 
            // espressoDelCup
            // 
            this.espressoDelCup.Location = new System.Drawing.Point(24, 117);
            this.espressoDelCup.Name = "espressoDelCup";
            this.espressoDelCup.Size = new System.Drawing.Size(31, 23);
            this.espressoDelCup.TabIndex = 9;
            this.espressoDelCup.Text = "-";
            this.espressoDelCup.UseVisualStyleBackColor = true;
            this.espressoDelCup.Click += new System.EventHandler(this.espressoDelCup_Click);
            // 
            // choiceEspresso
            // 
            this.choiceEspresso.AutoSize = true;
            this.choiceEspresso.Location = new System.Drawing.Point(24, 12);
            this.choiceEspresso.Name = "choiceEspresso";
            this.choiceEspresso.Size = new System.Drawing.Size(15, 14);
            this.choiceEspresso.TabIndex = 12;
            this.choiceEspresso.UseVisualStyleBackColor = true;
            this.choiceEspresso.CheckedChanged += new System.EventHandler(this.choiceEspresso_CheckedChanged);
            // 
            // cappuccinoAddCup
            // 
            this.cappuccinoAddCup.Location = new System.Drawing.Point(95, 266);
            this.cappuccinoAddCup.Name = "cappuccinoAddCup";
            this.cappuccinoAddCup.Size = new System.Drawing.Size(31, 23);
            this.cappuccinoAddCup.TabIndex = 9;
            this.cappuccinoAddCup.Text = "+";
            this.cappuccinoAddCup.UseVisualStyleBackColor = true;
            this.cappuccinoAddCup.Click += new System.EventHandler(this.cappuccinoAddCup_Click);
            // 
            // cappuccinoDelCup
            // 
            this.cappuccinoDelCup.Location = new System.Drawing.Point(24, 266);
            this.cappuccinoDelCup.Name = "cappuccinoDelCup";
            this.cappuccinoDelCup.Size = new System.Drawing.Size(31, 23);
            this.cappuccinoDelCup.TabIndex = 9;
            this.cappuccinoDelCup.Text = "-";
            this.cappuccinoDelCup.UseVisualStyleBackColor = true;
            this.cappuccinoDelCup.Click += new System.EventHandler(this.cappuccinoDelCup_Click);
            // 
            // cappuccinoCount
            // 
            this.cappuccinoCount.Location = new System.Drawing.Point(61, 266);
            this.cappuccinoCount.Name = "cappuccinoCount";
            this.cappuccinoCount.Size = new System.Drawing.Size(28, 20);
            this.cappuccinoCount.TabIndex = 11;
            // 
            // choiceCappuccino
            // 
            this.choiceCappuccino.AutoSize = true;
            this.choiceCappuccino.Location = new System.Drawing.Point(24, 161);
            this.choiceCappuccino.Name = "choiceCappuccino";
            this.choiceCappuccino.Size = new System.Drawing.Size(15, 14);
            this.choiceCappuccino.TabIndex = 12;
            this.choiceCappuccino.UseVisualStyleBackColor = true;
            this.choiceCappuccino.CheckedChanged += new System.EventHandler(this.choiceCappuccino_CheckedChanged);
            // 
            // americanoAddCup
            // 
            this.americanoAddCup.Location = new System.Drawing.Point(231, 117);
            this.americanoAddCup.Name = "americanoAddCup";
            this.americanoAddCup.Size = new System.Drawing.Size(31, 23);
            this.americanoAddCup.TabIndex = 9;
            this.americanoAddCup.Text = "+";
            this.americanoAddCup.UseVisualStyleBackColor = true;
            this.americanoAddCup.Click += new System.EventHandler(this.americanoAddCup_Click);
            // 
            // americanoDelCup
            // 
            this.americanoDelCup.Location = new System.Drawing.Point(160, 117);
            this.americanoDelCup.Name = "americanoDelCup";
            this.americanoDelCup.Size = new System.Drawing.Size(31, 23);
            this.americanoDelCup.TabIndex = 9;
            this.americanoDelCup.Text = "-";
            this.americanoDelCup.UseVisualStyleBackColor = true;
            this.americanoDelCup.Click += new System.EventHandler(this.americanoDelCup_Click);
            // 
            // americanoCount
            // 
            this.americanoCount.Location = new System.Drawing.Point(197, 117);
            this.americanoCount.Name = "americanoCount";
            this.americanoCount.Size = new System.Drawing.Size(28, 20);
            this.americanoCount.TabIndex = 11;
            // 
            // choiceAmericano
            // 
            this.choiceAmericano.AutoSize = true;
            this.choiceAmericano.Location = new System.Drawing.Point(160, 12);
            this.choiceAmericano.Name = "choiceAmericano";
            this.choiceAmericano.Size = new System.Drawing.Size(15, 14);
            this.choiceAmericano.TabIndex = 12;
            this.choiceAmericano.UseVisualStyleBackColor = true;
            this.choiceAmericano.CheckedChanged += new System.EventHandler(this.choiceAmericano_CheckedChanged);
            // 
            // latteAddCup
            // 
            this.latteAddCup.Location = new System.Drawing.Point(231, 266);
            this.latteAddCup.Name = "latteAddCup";
            this.latteAddCup.Size = new System.Drawing.Size(31, 23);
            this.latteAddCup.TabIndex = 9;
            this.latteAddCup.Text = "+";
            this.latteAddCup.UseVisualStyleBackColor = true;
            this.latteAddCup.Click += new System.EventHandler(this.latteAddCup_Click);
            // 
            // latteDelCup
            // 
            this.latteDelCup.Location = new System.Drawing.Point(160, 266);
            this.latteDelCup.Name = "latteDelCup";
            this.latteDelCup.Size = new System.Drawing.Size(31, 23);
            this.latteDelCup.TabIndex = 9;
            this.latteDelCup.Text = "-";
            this.latteDelCup.UseVisualStyleBackColor = true;
            this.latteDelCup.Click += new System.EventHandler(this.latteDelCup_Click);
            // 
            // latteCount
            // 
            this.latteCount.Location = new System.Drawing.Point(197, 266);
            this.latteCount.Name = "latteCount";
            this.latteCount.Size = new System.Drawing.Size(28, 20);
            this.latteCount.TabIndex = 11;
            // 
            // choiceLatte
            // 
            this.choiceLatte.AutoSize = true;
            this.choiceLatte.Location = new System.Drawing.Point(160, 161);
            this.choiceLatte.Name = "choiceLatte";
            this.choiceLatte.Size = new System.Drawing.Size(15, 14);
            this.choiceLatte.TabIndex = 12;
            this.choiceLatte.UseVisualStyleBackColor = true;
            this.choiceLatte.CheckedChanged += new System.EventHandler(this.choiceLatte_CheckedChanged);
            // 
            // latte
            // 
            this.latte.Image = global::CoffeeShop.Properties.Resources.latte;
            this.latte.Location = new System.Drawing.Point(160, 161);
            this.latte.Name = "latte";
            this.latte.Size = new System.Drawing.Size(102, 102);
            this.latte.TabIndex = 8;
            this.latte.TabStop = false;
            this.latte.Click += new System.EventHandler(this.latte_Click);
            // 
            // americano
            // 
            this.americano.Image = global::CoffeeShop.Properties.Resources.americano;
            this.americano.Location = new System.Drawing.Point(160, 12);
            this.americano.Name = "americano";
            this.americano.Size = new System.Drawing.Size(102, 102);
            this.americano.TabIndex = 8;
            this.americano.TabStop = false;
            this.americano.Click += new System.EventHandler(this.americano_Click);
            // 
            // cappuccino
            // 
            this.cappuccino.Image = global::CoffeeShop.Properties.Resources.cappuccino;
            this.cappuccino.Location = new System.Drawing.Point(24, 161);
            this.cappuccino.Name = "cappuccino";
            this.cappuccino.Size = new System.Drawing.Size(102, 102);
            this.cappuccino.TabIndex = 8;
            this.cappuccino.TabStop = false;
            this.cappuccino.Click += new System.EventHandler(this.cappuccino_Click);
            // 
            // espresso
            // 
            this.espresso.Image = global::CoffeeShop.Properties.Resources.espresso;
            this.espresso.Location = new System.Drawing.Point(24, 12);
            this.espresso.Name = "espresso";
            this.espresso.Size = new System.Drawing.Size(102, 102);
            this.espresso.TabIndex = 8;
            this.espresso.TabStop = false;
            this.espresso.Click += new System.EventHandler(this.espresso_Click);
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(279, 12);
            this.about.Multiline = true;
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(266, 277);
            this.about.TabIndex = 13;
            this.about.TextChanged += new System.EventHandler(this.about_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 372);
            this.Controls.Add(this.about);
            this.Controls.Add(this.choiceLatte);
            this.Controls.Add(this.choiceAmericano);
            this.Controls.Add(this.choiceCappuccino);
            this.Controls.Add(this.choiceEspresso);
            this.Controls.Add(this.latteCount);
            this.Controls.Add(this.americanoCount);
            this.Controls.Add(this.cappuccinoCount);
            this.Controls.Add(this.espressoCount);
            this.Controls.Add(this.latteDelCup);
            this.Controls.Add(this.americanoDelCup);
            this.Controls.Add(this.cappuccinoDelCup);
            this.Controls.Add(this.espressoDelCup);
            this.Controls.Add(this.latteAddCup);
            this.Controls.Add(this.americanoAddCup);
            this.Controls.Add(this.cappuccinoAddCup);
            this.Controls.Add(this.espressoAddCup);
            this.Controls.Add(this.latte);
            this.Controls.Add(this.americano);
            this.Controls.Add(this.cappuccino);
            this.Controls.Add(this.espresso);
            this.Controls.Add(this.newOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.latte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.americano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cappuccino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espresso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newOrder;
        private System.Windows.Forms.PictureBox espresso;
        private System.Windows.Forms.Button espressoAddCup;
        private System.Windows.Forms.TextBox espressoCount;
        private System.Windows.Forms.Button espressoDelCup;
        private System.Windows.Forms.CheckBox choiceEspresso;
        private System.Windows.Forms.PictureBox cappuccino;
        private System.Windows.Forms.Button cappuccinoAddCup;
        private System.Windows.Forms.Button cappuccinoDelCup;
        private System.Windows.Forms.TextBox cappuccinoCount;
        private System.Windows.Forms.CheckBox choiceCappuccino;
        private System.Windows.Forms.PictureBox americano;
        private System.Windows.Forms.Button americanoAddCup;
        private System.Windows.Forms.Button americanoDelCup;
        private System.Windows.Forms.TextBox americanoCount;
        private System.Windows.Forms.CheckBox choiceAmericano;
        private System.Windows.Forms.PictureBox latte;
        private System.Windows.Forms.Button latteAddCup;
        private System.Windows.Forms.Button latteDelCup;
        private System.Windows.Forms.TextBox latteCount;
        private System.Windows.Forms.CheckBox choiceLatte;
        private System.Windows.Forms.TextBox about;
    }
}

