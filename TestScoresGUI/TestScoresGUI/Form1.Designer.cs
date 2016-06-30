namespace TestScoresGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.avgLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.score1TextBox = new System.Windows.Forms.TextBox();
            this.score2TextBox = new System.Windows.Forms.TextBox();
            this.score3TextBox = new System.Windows.Forms.TextBox();
            this.score4TextBox = new System.Windows.Forms.TextBox();
            this.score5TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Test Score 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Test Score 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Test Score 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter Test Score 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enter Test Score 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Average Test Score";
            // 
            // avgLabel
            // 
            this.avgLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.avgLabel.Location = new System.Drawing.Point(154, 189);
            this.avgLabel.Name = "avgLabel";
            this.avgLabel.Size = new System.Drawing.Size(100, 23);
            this.avgLabel.TabIndex = 6;
            this.avgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Find Average";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(154, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "&Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // score1TextBox
            // 
            this.score1TextBox.Location = new System.Drawing.Point(154, 35);
            this.score1TextBox.Name = "score1TextBox";
            this.score1TextBox.Size = new System.Drawing.Size(100, 20);
            this.score1TextBox.TabIndex = 0;
            this.score1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.score1TextBox.TextChanged += new System.EventHandler(this.score1TextBox_TextChanged);
            // 
            // score2TextBox
            // 
            this.score2TextBox.Location = new System.Drawing.Point(154, 66);
            this.score2TextBox.Name = "score2TextBox";
            this.score2TextBox.Size = new System.Drawing.Size(100, 20);
            this.score2TextBox.TabIndex = 1;
            this.score2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // score3TextBox
            // 
            this.score3TextBox.Location = new System.Drawing.Point(154, 97);
            this.score3TextBox.Name = "score3TextBox";
            this.score3TextBox.Size = new System.Drawing.Size(100, 20);
            this.score3TextBox.TabIndex = 2;
            this.score3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // score4TextBox
            // 
            this.score4TextBox.Location = new System.Drawing.Point(154, 128);
            this.score4TextBox.Name = "score4TextBox";
            this.score4TextBox.Size = new System.Drawing.Size(100, 20);
            this.score4TextBox.TabIndex = 3;
            this.score4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // score5TextBox
            // 
            this.score5TextBox.Location = new System.Drawing.Point(154, 159);
            this.score5TextBox.Name = "score5TextBox";
            this.score5TextBox.Size = new System.Drawing.Size(100, 20);
            this.score5TextBox.TabIndex = 4;
            this.score5TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(306, 312);
            this.Controls.Add(this.score5TextBox);
            this.Controls.Add(this.score4TextBox);
            this.Controls.Add(this.score3TextBox);
            this.Controls.Add(this.score2TextBox);
            this.Controls.Add(this.score1TextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.avgLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Average Test Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label avgLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox score1TextBox;
        private System.Windows.Forms.TextBox score2TextBox;
        private System.Windows.Forms.TextBox score3TextBox;
        private System.Windows.Forms.TextBox score4TextBox;
        private System.Windows.Forms.TextBox score5TextBox;
    }
}

