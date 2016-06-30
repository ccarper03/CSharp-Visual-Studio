namespace RestaurantGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.appListBox = new System.Windows.Forms.ListBox();
            this.entreeListBox = new System.Windows.Forms.ListBox();
            this.dsrtListBox = new System.Windows.Forms.ListBox();
            this.displayLabel = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose one item from each category and click the View Cost button";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Appetizers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Entrees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Deserts";
            // 
            // appListBox
            // 
            this.appListBox.FormattingEnabled = true;
            this.appListBox.ItemHeight = 16;
            this.appListBox.Items.AddRange(new object[] {
            "Steak Fries & Cheese",
            "Shrimp Cocktail",
            "Stuffed Mushrooms"});
            this.appListBox.Location = new System.Drawing.Point(42, 100);
            this.appListBox.Margin = new System.Windows.Forms.Padding(4);
            this.appListBox.Name = "appListBox";
            this.appListBox.Size = new System.Drawing.Size(159, 52);
            this.appListBox.TabIndex = 8;
            // 
            // entreeListBox
            // 
            this.entreeListBox.FormattingEnabled = true;
            this.entreeListBox.ItemHeight = 16;
            this.entreeListBox.Items.AddRange(new object[] {
            "Lasagna with Meat Sauce",
            "Linguini with Clam Sauce",
            "Spaghetti with Marinara Sauce"});
            this.entreeListBox.Location = new System.Drawing.Point(229, 100);
            this.entreeListBox.Margin = new System.Windows.Forms.Padding(4);
            this.entreeListBox.Name = "entreeListBox";
            this.entreeListBox.Size = new System.Drawing.Size(159, 52);
            this.entreeListBox.TabIndex = 9;
            // 
            // dsrtListBox
            // 
            this.dsrtListBox.FormattingEnabled = true;
            this.dsrtListBox.ItemHeight = 16;
            this.dsrtListBox.Items.AddRange(new object[] {
            "Cannoli",
            "Chocholate Truffle",
            "Tira Mi Su"});
            this.dsrtListBox.Location = new System.Drawing.Point(418, 100);
            this.dsrtListBox.Margin = new System.Windows.Forms.Padding(4);
            this.dsrtListBox.Name = "dsrtListBox";
            this.dsrtListBox.Size = new System.Drawing.Size(159, 52);
            this.dsrtListBox.TabIndex = 10;
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(42, 170);
            this.displayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(536, 40);
            this.displayLabel.TabIndex = 11;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(42, 227);
            this.viewButton.Margin = new System.Windows.Forms.Padding(4);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(137, 27);
            this.viewButton.TabIndex = 1;
            this.viewButton.Text = "&View Cost";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(242, 227);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(137, 27);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "&Reset interface";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(441, 227);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(137, 27);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 299);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.dsrtListBox);
            this.Controls.Add(this.entreeListBox);
            this.Controls.Add(this.appListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox appListBox;
        private System.Windows.Forms.ListBox entreeListBox;
        private System.Windows.Forms.ListBox dsrtListBox;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
    }
}

