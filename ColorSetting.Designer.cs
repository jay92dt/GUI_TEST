namespace GUI_TEST
{
    partial class ColorSetting
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
            this.checkBox_ManualColor = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBox_BAVG = new System.Windows.Forms.TextBox();
            this.TextBox_BMAX = new System.Windows.Forms.TextBox();
            this.TextBox_GAVG = new System.Windows.Forms.TextBox();
            this.TextBox_GMAX = new System.Windows.Forms.TextBox();
            this.TextBox_RAVG = new System.Windows.Forms.TextBox();
            this.TextBox_RMAX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_DefaultColor = new System.Windows.Forms.CheckBox();
            this.ColorSetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_BMIN = new System.Windows.Forms.TextBox();
            this.TextBox_GMIN = new System.Windows.Forms.TextBox();
            this.TextBox_RMIN = new System.Windows.Forms.TextBox();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_ManualColor
            // 
            this.checkBox_ManualColor.AutoSize = true;
            this.checkBox_ManualColor.Location = new System.Drawing.Point(292, 35);
            this.checkBox_ManualColor.Name = "checkBox_ManualColor";
            this.checkBox_ManualColor.Size = new System.Drawing.Size(161, 22);
            this.checkBox_ManualColor.TabIndex = 21;
            this.checkBox_ManualColor.Text = "Color 수동 설정";
            this.checkBox_ManualColor.UseVisualStyleBackColor = true;
            this.checkBox_ManualColor.CheckedChanged += new System.EventHandler(this.checkBox_ManualColor_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.TextBox_BMIN);
            this.panel5.Controls.Add(this.TextBox_GMIN);
            this.panel5.Controls.Add(this.TextBox_RMIN);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.TextBox_BAVG);
            this.panel5.Controls.Add(this.TextBox_BMAX);
            this.panel5.Controls.Add(this.TextBox_GAVG);
            this.panel5.Controls.Add(this.TextBox_GMAX);
            this.panel5.Controls.Add(this.TextBox_RAVG);
            this.panel5.Controls.Add(this.TextBox_RMAX);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(198, 63);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(482, 150);
            this.panel5.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 27);
            this.label12.TabIndex = 5;
            this.label12.Text = "Avg :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 27);
            this.label11.TabIndex = 5;
            this.label11.Text = "Max :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_BAVG
            // 
            this.TextBox_BAVG.Location = new System.Drawing.Point(348, 70);
            this.TextBox_BAVG.Name = "TextBox_BAVG";
            this.TextBox_BAVG.Size = new System.Drawing.Size(119, 28);
            this.TextBox_BAVG.TabIndex = 16;
            // 
            // TextBox_BMAX
            // 
            this.TextBox_BMAX.Location = new System.Drawing.Point(348, 34);
            this.TextBox_BMAX.Name = "TextBox_BMAX";
            this.TextBox_BMAX.Size = new System.Drawing.Size(119, 28);
            this.TextBox_BMAX.TabIndex = 16;
            // 
            // TextBox_GAVG
            // 
            this.TextBox_GAVG.Location = new System.Drawing.Point(217, 70);
            this.TextBox_GAVG.Name = "TextBox_GAVG";
            this.TextBox_GAVG.Size = new System.Drawing.Size(119, 28);
            this.TextBox_GAVG.TabIndex = 16;
            // 
            // TextBox_GMAX
            // 
            this.TextBox_GMAX.Location = new System.Drawing.Point(217, 34);
            this.TextBox_GMAX.Name = "TextBox_GMAX";
            this.TextBox_GMAX.Size = new System.Drawing.Size(119, 28);
            this.TextBox_GMAX.TabIndex = 16;
            // 
            // TextBox_RAVG
            // 
            this.TextBox_RAVG.Location = new System.Drawing.Point(83, 70);
            this.TextBox_RAVG.Name = "TextBox_RAVG";
            this.TextBox_RAVG.Size = new System.Drawing.Size(119, 28);
            this.TextBox_RAVG.TabIndex = 14;
            // 
            // TextBox_RMAX
            // 
            this.TextBox_RMAX.Location = new System.Drawing.Point(83, 34);
            this.TextBox_RMAX.Name = "TextBox_RMAX";
            this.TextBox_RMAX.Size = new System.Drawing.Size(119, 28);
            this.TextBox_RMAX.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(343, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "Blue";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(212, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Green";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Red";
            // 
            // checkBox_DefaultColor
            // 
            this.checkBox_DefaultColor.AutoSize = true;
            this.checkBox_DefaultColor.Checked = true;
            this.checkBox_DefaultColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_DefaultColor.Location = new System.Drawing.Point(198, 35);
            this.checkBox_DefaultColor.Name = "checkBox_DefaultColor";
            this.checkBox_DefaultColor.Size = new System.Drawing.Size(88, 22);
            this.checkBox_DefaultColor.TabIndex = 22;
            this.checkBox_DefaultColor.Text = "Default";
            this.checkBox_DefaultColor.UseVisualStyleBackColor = true;
            this.checkBox_DefaultColor.CheckedChanged += new System.EventHandler(this.checkBox_DefaultColor_CheckedChanged);
            // 
            // ColorSetButton
            // 
            this.ColorSetButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorSetButton.Location = new System.Drawing.Point(51, 63);
            this.ColorSetButton.Name = "ColorSetButton";
            this.ColorSetButton.Size = new System.Drawing.Size(113, 150);
            this.ColorSetButton.TabIndex = 23;
            this.ColorSetButton.Text = "Set";
            this.ColorSetButton.UseVisualStyleBackColor = true;
            this.ColorSetButton.Click += new System.EventHandler(this.ColorSetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Min :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_BMIN
            // 
            this.TextBox_BMIN.Location = new System.Drawing.Point(348, 106);
            this.TextBox_BMIN.Name = "TextBox_BMIN";
            this.TextBox_BMIN.Size = new System.Drawing.Size(119, 28);
            this.TextBox_BMIN.TabIndex = 19;
            // 
            // TextBox_GMIN
            // 
            this.TextBox_GMIN.Location = new System.Drawing.Point(217, 106);
            this.TextBox_GMIN.Name = "TextBox_GMIN";
            this.TextBox_GMIN.Size = new System.Drawing.Size(119, 28);
            this.TextBox_GMIN.TabIndex = 20;
            // 
            // TextBox_RMIN
            // 
            this.TextBox_RMIN.Location = new System.Drawing.Point(83, 106);
            this.TextBox_RMIN.Name = "TextBox_RMIN";
            this.TextBox_RMIN.Size = new System.Drawing.Size(119, 28);
            this.TextBox_RMIN.TabIndex = 18;
            // 
            // ColorSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 256);
            this.Controls.Add(this.ColorSetButton);
            this.Controls.Add(this.checkBox_DefaultColor);
            this.Controls.Add(this.checkBox_ManualColor);
            this.Controls.Add(this.panel5);
            this.Name = "ColorSetting";
            this.Text = "Color Setting";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_ManualColor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextBox_BAVG;
        private System.Windows.Forms.TextBox TextBox_BMAX;
        private System.Windows.Forms.TextBox TextBox_GAVG;
        private System.Windows.Forms.TextBox TextBox_GMAX;
        private System.Windows.Forms.TextBox TextBox_RAVG;
        private System.Windows.Forms.TextBox TextBox_RMAX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox_DefaultColor;
        private System.Windows.Forms.Button ColorSetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_BMIN;
        private System.Windows.Forms.TextBox TextBox_GMIN;
        private System.Windows.Forms.TextBox TextBox_RMIN;
    }
}