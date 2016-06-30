namespace MyTunesGUI
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
            this.displayLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(31, 192);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(310, 33);
            this.displayLabel.TabIndex = 0;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit Application";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.Items.AddRange(new object[] {
            "Thriller - Michael Jackson",
            "Rocket Man - Elton John",
            "Atomic Dog - George Clinton",
            "Highway to Hell - ACDC",
            "Bad Company - Bad Company",
            "Born in the USA - Bruce Springsteen",
            "God Blessed Texas - Diamond Rio",
            "Beast of Burden - Rolling Stones"});
            this.itemListBox.Location = new System.Drawing.Point(31, 68);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.itemListBox.Size = new System.Drawing.Size(310, 108);
            this.itemListBox.TabIndex = 2;
            this.itemListBox.SelectedIndexChanged += new System.EventHandler(this.itemListBox_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Purchase multiple songs by holding down the ctrl key while making selections. Dow" +
    "nload cost is $0.99 per song.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(369, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.displayLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyTunes";
            this.Click += new System.EventHandler(this.itemListBox_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.Label label1;
    }
}

