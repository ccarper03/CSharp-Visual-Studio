namespace FinalExamGUI
{
    partial class Form6
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
            this.inputTextBox2 = new System.Windows.Forms.TextBox();
            this.sNumLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.prdctBtn = new System.Windows.Forms.Button();
            this.productDisplayLabel = new System.Windows.Forms.Label();
            this.inputTextBox1 = new System.Windows.Forms.TextBox();
            this.fNumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox2
            // 
            this.inputTextBox2.Location = new System.Drawing.Point(225, 89);
            this.inputTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.inputTextBox2.Name = "inputTextBox2";
            this.inputTextBox2.Size = new System.Drawing.Size(132, 22);
            this.inputTextBox2.TabIndex = 18;
            // 
            // sNumLabel
            // 
            this.sNumLabel.AutoSize = true;
            this.sNumLabel.Location = new System.Drawing.Point(13, 92);
            this.sNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sNumLabel.Name = "sNumLabel";
            this.sNumLabel.Size = new System.Drawing.Size(148, 17);
            this.sNumLabel.TabIndex = 17;
            this.sNumLabel.Text = "Enter Second Number";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(204, 246);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(161, 28);
            this.closeBtn.TabIndex = 16;
            this.closeBtn.Text = "&Close Form";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // prdctBtn
            // 
            this.prdctBtn.Location = new System.Drawing.Point(24, 246);
            this.prdctBtn.Margin = new System.Windows.Forms.Padding(4);
            this.prdctBtn.Name = "prdctBtn";
            this.prdctBtn.Size = new System.Drawing.Size(140, 28);
            this.prdctBtn.TabIndex = 15;
            this.prdctBtn.Text = "&Product";
            this.prdctBtn.UseVisualStyleBackColor = true;
            this.prdctBtn.Click += new System.EventHandler(this.prdctBtn_Click);
            // 
            // productDisplayLabel
            // 
            this.productDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productDisplayLabel.Location = new System.Drawing.Point(24, 154);
            this.productDisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productDisplayLabel.Name = "productDisplayLabel";
            this.productDisplayLabel.Size = new System.Drawing.Size(341, 47);
            this.productDisplayLabel.TabIndex = 14;
            // 
            // inputTextBox1
            // 
            this.inputTextBox1.Location = new System.Drawing.Point(225, 49);
            this.inputTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.inputTextBox1.Name = "inputTextBox1";
            this.inputTextBox1.Size = new System.Drawing.Size(132, 22);
            this.inputTextBox1.TabIndex = 13;
            this.inputTextBox1.TextChanged += new System.EventHandler(this.inputTextBox1_TextChanged);
            // 
            // fNumLabel
            // 
            this.fNumLabel.AutoSize = true;
            this.fNumLabel.Location = new System.Drawing.Point(13, 53);
            this.fNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fNumLabel.Name = "fNumLabel";
            this.fNumLabel.Size = new System.Drawing.Size(127, 17);
            this.fNumLabel.TabIndex = 12;
            this.fNumLabel.Text = "Enter First Number";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.inputTextBox2);
            this.Controls.Add(this.sNumLabel);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.prdctBtn);
            this.Controls.Add(this.productDisplayLabel);
            this.Controls.Add(this.inputTextBox1);
            this.Controls.Add(this.fNumLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product of Two Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox2;
        private System.Windows.Forms.Label sNumLabel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button prdctBtn;
        private System.Windows.Forms.Label productDisplayLabel;
        private System.Windows.Forms.TextBox inputTextBox1;
        private System.Windows.Forms.Label fNumLabel;

    }
}