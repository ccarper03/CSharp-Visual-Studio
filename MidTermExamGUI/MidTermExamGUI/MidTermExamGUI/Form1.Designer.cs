namespace MidTermExamGUI
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
            this.displayLabel = new System.Windows.Forms.Label();
            this.numDrawersTextBox = new System.Windows.Forms.TextBox();
            this.woodTypeTextBox = new System.Windows.Forms.TextBox();
            this.getQuoteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of Drawers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type of Wood (P, O, M)";
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(54, 95);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(239, 63);
            this.displayLabel.TabIndex = 3;
            // 
            // numDrawersTextBox
            // 
            this.numDrawersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawersTextBox.Location = new System.Drawing.Point(197, 34);
            this.numDrawersTextBox.Name = "numDrawersTextBox";
            this.numDrawersTextBox.Size = new System.Drawing.Size(70, 21);
            this.numDrawersTextBox.TabIndex = 1;
            this.numDrawersTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDrawersTextBox.TextChanged += new System.EventHandler(this.numDrawersTextBox_TextChanged);
            // 
            // woodTypeTextBox
            // 
            this.woodTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.woodTypeTextBox.Location = new System.Drawing.Point(197, 58);
            this.woodTypeTextBox.Name = "woodTypeTextBox";
            this.woodTypeTextBox.Size = new System.Drawing.Size(70, 21);
            this.woodTypeTextBox.TabIndex = 2;
            this.woodTypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.woodTypeTextBox.TextChanged += new System.EventHandler(this.woodTypeTextBox_TextChanged);
            // 
            // getQuoteButton
            // 
            this.getQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getQuoteButton.Location = new System.Drawing.Point(54, 176);
            this.getQuoteButton.Name = "getQuoteButton";
            this.getQuoteButton.Size = new System.Drawing.Size(116, 36);
            this.getQuoteButton.TabIndex = 4;
            this.getQuoteButton.Text = "&Get Quote";
            this.getQuoteButton.UseVisualStyleBackColor = true;
            this.getQuoteButton.Click += new System.EventHandler(this.getQuoteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(177, 176);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(116, 36);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.getQuoteButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(342, 252);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getQuoteButton);
            this.Controls.Add(this.woodTypeTextBox);
            this.Controls.Add(this.numDrawersTextBox);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Desks - Price Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.TextBox numDrawersTextBox;
        private System.Windows.Forms.TextBox woodTypeTextBox;
        private System.Windows.Forms.Button getQuoteButton;
        private System.Windows.Forms.Button exitButton;
    }
}

