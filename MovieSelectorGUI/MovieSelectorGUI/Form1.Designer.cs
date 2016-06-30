namespace MovieSelectorGUI
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
            this.movListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.strtTimeLabel = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.slctLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Movies";
            // 
            // movListBox
            // 
            this.movListBox.FormattingEnabled = true;
            this.movListBox.ItemHeight = 16;
            this.movListBox.Items.AddRange(new object[] {
            "The Amazing Spider-Man",
            "The Other Woman",
            "Brick Mansions",
            "Heaven Is for Real",
            "Rio 2"});
            this.movListBox.Location = new System.Drawing.Point(28, 48);
            this.movListBox.Name = "movListBox";
            this.movListBox.Size = new System.Drawing.Size(169, 84);
            this.movListBox.TabIndex = 0;
            this.movListBox.SelectedIndexChanged += new System.EventHandler(this.movListBox_SelectedIndexChanged);
            this.movListBox.MouseLeave += new System.EventHandler(this.movListBox_MouseLeave);
            this.movListBox.MouseHover += new System.EventHandler(this.movListBox_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Starting Times";
            // 
            // strtTimeLabel
            // 
            this.strtTimeLabel.AutoSize = true;
            this.strtTimeLabel.Location = new System.Drawing.Point(229, 48);
            this.strtTimeLabel.Name = "strtTimeLabel";
            this.strtTimeLabel.Size = new System.Drawing.Size(158, 85);
            this.strtTimeLabel.TabIndex = 4;
            this.strtTimeLabel.Text = "7:00 p.m. and 9:30 p.m.\r\n7:05 p.m. and 9:20 p.m.\r\n7:15 p.m. and 9:00 p.m.\r\n7:10 p" +
    ".m. and 9:05 p.m.\r\n7:00 p.m. and 9:00 p.m.\r\n";
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Location = new System.Drawing.Point(28, 187);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(343, 28);
            this.displayLabel.TabIndex = 6;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(115, 237);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(184, 46);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // slctLabel
            // 
            this.slctLabel.AutoSize = true;
            this.slctLabel.ForeColor = System.Drawing.Color.Red;
            this.slctLabel.Location = new System.Drawing.Point(105, 151);
            this.slctLabel.Name = "slctLabel";
            this.slctLabel.Size = new System.Drawing.Size(204, 17);
            this.slctLabel.TabIndex = 5;
            this.slctLabel.Text = "Select a movie by clicking on it.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(415, 315);
            this.Controls.Add(this.slctLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.strtTimeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.movListBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox movListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label strtTimeLabel;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label slctLabel;
    }
}

