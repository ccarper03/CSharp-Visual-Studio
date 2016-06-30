namespace FinalExamGUI
{
    partial class Form3
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.cubeBtn = new System.Windows.Forms.Button();
            this.cubeDisplayLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(235, 224);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(161, 28);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "&Close Form";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // cubeBtn
            // 
            this.cubeBtn.Location = new System.Drawing.Point(55, 224);
            this.cubeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cubeBtn.Name = "cubeBtn";
            this.cubeBtn.Size = new System.Drawing.Size(140, 28);
            this.cubeBtn.TabIndex = 8;
            this.cubeBtn.Text = "&Cube";
            this.cubeBtn.UseVisualStyleBackColor = true;
            this.cubeBtn.Click += new System.EventHandler(this.cubeBtn_Click);
            // 
            // cubeDisplayLabel
            // 
            this.cubeDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cubeDisplayLabel.Location = new System.Drawing.Point(55, 132);
            this.cubeDisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cubeDisplayLabel.Name = "cubeDisplayLabel";
            this.cubeDisplayLabel.Size = new System.Drawing.Size(341, 47);
            this.cubeDisplayLabel.TabIndex = 7;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(256, 58);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(132, 22);
            this.inputTextBox.TabIndex = 6;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Number to Cube";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 353);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.cubeBtn);
            this.Controls.Add(this.cubeDisplayLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cube a Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button cubeBtn;
        private System.Windows.Forms.Label cubeDisplayLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
    }
}