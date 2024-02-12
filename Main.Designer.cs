namespace GUI_TEST
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.RefPath_TextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CompPath_TextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.OpenColorSetting = new System.Windows.Forms.Button();
            this.pictureBox_Ref = new System.Windows.Forms.PictureBox();
            this.pictureBox_Comp = new System.Windows.Forms.PictureBox();
            this.pictureBox_Diff = new System.Windows.Forms.PictureBox();
            this.ColorBar_Ref = new System.Windows.Forms.PictureBox();
            this.MaxLabel_Ref = new System.Windows.Forms.Label();
            this.MinLabel_Ref = new System.Windows.Forms.Label();
            this.MinLabel_Comp = new System.Windows.Forms.Label();
            this.MaxLabel_Comp = new System.Windows.Forms.Label();
            this.ColorBar_Comp = new System.Windows.Forms.PictureBox();
            this.ColorBar_Diff = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AvgLabel_Ref = new System.Windows.Forms.Label();
            this.AvgLabel_Comp = new System.Windows.Forms.Label();
            this.MaxLabel_Diff = new System.Windows.Forms.Label();
            this.MinLabel_Diff = new System.Windows.Forms.Label();
            this.AvgLabel_Diff = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Diff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBar_Ref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBar_Comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBar_Diff)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1784, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "···";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OpenRef_Click);
            // 
            // RefPath_TextBox
            // 
            this.RefPath_TextBox.Location = new System.Drawing.Point(114, 18);
            this.RefPath_TextBox.Name = "RefPath_TextBox";
            this.RefPath_TextBox.Size = new System.Drawing.Size(1640, 28);
            this.RefPath_TextBox.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CompPath_TextBox
            // 
            this.CompPath_TextBox.Location = new System.Drawing.Point(114, 62);
            this.CompPath_TextBox.Name = "CompPath_TextBox";
            this.CompPath_TextBox.Size = new System.Drawing.Size(1640, 28);
            this.CompPath_TextBox.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1784, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 28);
            this.button4.TabIndex = 0;
            this.button4.Text = "···";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OpenComp_Click);
            // 
            // RunButton
            // 
            this.RunButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RunButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunButton.Location = new System.Drawing.Point(75, 50);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(188, 108);
            this.RunButton.TabIndex = 4;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.HeatMapGen);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Comp :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(297, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "파일 불러오기";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ref :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CompPath_TextBox);
            this.panel1.Controls.Add(this.RefPath_TextBox);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(302, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1875, 108);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ref Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(894, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "Comp Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1719, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 33);
            this.label6.TabIndex = 13;
            this.label6.Text = "Diff Image";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(70, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "이미지 생성";
            // 
            // OpenColorSetting
            // 
            this.OpenColorSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenColorSetting.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenColorSetting.Location = new System.Drawing.Point(2211, 50);
            this.OpenColorSetting.Name = "OpenColorSetting";
            this.OpenColorSetting.Size = new System.Drawing.Size(211, 108);
            this.OpenColorSetting.TabIndex = 14;
            this.OpenColorSetting.Text = "Color Setting";
            this.OpenColorSetting.UseVisualStyleBackColor = true;
            this.OpenColorSetting.Click += new System.EventHandler(this.OpenColorSetting_Click);
            // 
            // pictureBox_Ref
            // 
            this.pictureBox_Ref.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox_Ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Ref.Location = new System.Drawing.Point(75, 244);
            this.pictureBox_Ref.Name = "pictureBox_Ref";
            this.pictureBox_Ref.Size = new System.Drawing.Size(639, 353);
            this.pictureBox_Ref.TabIndex = 15;
            this.pictureBox_Ref.TabStop = false;
            // 
            // pictureBox_Comp
            // 
            this.pictureBox_Comp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox_Comp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Comp.Location = new System.Drawing.Point(900, 244);
            this.pictureBox_Comp.Name = "pictureBox_Comp";
            this.pictureBox_Comp.Size = new System.Drawing.Size(639, 353);
            this.pictureBox_Comp.TabIndex = 16;
            this.pictureBox_Comp.TabStop = false;
            // 
            // pictureBox_Diff
            // 
            this.pictureBox_Diff.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox_Diff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Diff.Location = new System.Drawing.Point(1725, 235);
            this.pictureBox_Diff.Name = "pictureBox_Diff";
            this.pictureBox_Diff.Size = new System.Drawing.Size(639, 353);
            this.pictureBox_Diff.TabIndex = 16;
            this.pictureBox_Diff.TabStop = false;
            // 
            // ColorBar_Ref
            // 
            this.ColorBar_Ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorBar_Ref.Location = new System.Drawing.Point(735, 244);
            this.ColorBar_Ref.Name = "ColorBar_Ref";
            this.ColorBar_Ref.Size = new System.Drawing.Size(37, 353);
            this.ColorBar_Ref.TabIndex = 17;
            this.ColorBar_Ref.TabStop = false;
            // 
            // MaxLabel_Ref
            // 
            this.MaxLabel_Ref.AutoSize = true;
            this.MaxLabel_Ref.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MaxLabel_Ref.Location = new System.Drawing.Point(778, 244);
            this.MaxLabel_Ref.Name = "MaxLabel_Ref";
            this.MaxLabel_Ref.Size = new System.Drawing.Size(43, 18);
            this.MaxLabel_Ref.TabIndex = 18;
            this.MaxLabel_Ref.Text = "Max";
            // 
            // MinLabel_Ref
            // 
            this.MinLabel_Ref.AutoSize = true;
            this.MinLabel_Ref.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MinLabel_Ref.Location = new System.Drawing.Point(775, 579);
            this.MinLabel_Ref.Name = "MinLabel_Ref";
            this.MinLabel_Ref.Size = new System.Drawing.Size(36, 18);
            this.MinLabel_Ref.TabIndex = 18;
            this.MinLabel_Ref.Text = "Min";
            // 
            // MinLabel_Comp
            // 
            this.MinLabel_Comp.AutoSize = true;
            this.MinLabel_Comp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MinLabel_Comp.Location = new System.Drawing.Point(1600, 579);
            this.MinLabel_Comp.Name = "MinLabel_Comp";
            this.MinLabel_Comp.Size = new System.Drawing.Size(36, 18);
            this.MinLabel_Comp.TabIndex = 21;
            this.MinLabel_Comp.Text = "Min";
            // 
            // MaxLabel_Comp
            // 
            this.MaxLabel_Comp.AutoSize = true;
            this.MaxLabel_Comp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MaxLabel_Comp.Location = new System.Drawing.Point(1600, 244);
            this.MaxLabel_Comp.Name = "MaxLabel_Comp";
            this.MaxLabel_Comp.Size = new System.Drawing.Size(43, 18);
            this.MaxLabel_Comp.TabIndex = 20;
            this.MaxLabel_Comp.Text = "Max";
            // 
            // ColorBar_Comp
            // 
            this.ColorBar_Comp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorBar_Comp.Location = new System.Drawing.Point(1560, 244);
            this.ColorBar_Comp.Name = "ColorBar_Comp";
            this.ColorBar_Comp.Size = new System.Drawing.Size(37, 353);
            this.ColorBar_Comp.TabIndex = 19;
            this.ColorBar_Comp.TabStop = false;
            // 
            // ColorBar_Diff
            // 
            this.ColorBar_Diff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorBar_Diff.Location = new System.Drawing.Point(2385, 235);
            this.ColorBar_Diff.Name = "ColorBar_Diff";
            this.ColorBar_Diff.Size = new System.Drawing.Size(37, 353);
            this.ColorBar_Diff.TabIndex = 22;
            this.ColorBar_Diff.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(2206, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "Color 설정";
            // 
            // AvgLabel_Ref
            // 
            this.AvgLabel_Ref.AutoSize = true;
            this.AvgLabel_Ref.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AvgLabel_Ref.Location = new System.Drawing.Point(775, 411);
            this.AvgLabel_Ref.Name = "AvgLabel_Ref";
            this.AvgLabel_Ref.Size = new System.Drawing.Size(40, 18);
            this.AvgLabel_Ref.TabIndex = 18;
            this.AvgLabel_Ref.Text = "Avg";
            // 
            // AvgLabel_Comp
            // 
            this.AvgLabel_Comp.AutoSize = true;
            this.AvgLabel_Comp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AvgLabel_Comp.Location = new System.Drawing.Point(1600, 411);
            this.AvgLabel_Comp.Name = "AvgLabel_Comp";
            this.AvgLabel_Comp.Size = new System.Drawing.Size(40, 18);
            this.AvgLabel_Comp.TabIndex = 26;
            this.AvgLabel_Comp.Text = "Avg";
            // 
            // MaxLabel_Diff
            // 
            this.MaxLabel_Diff.AutoSize = true;
            this.MaxLabel_Diff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MaxLabel_Diff.Location = new System.Drawing.Point(2425, 235);
            this.MaxLabel_Diff.Name = "MaxLabel_Diff";
            this.MaxLabel_Diff.Size = new System.Drawing.Size(43, 18);
            this.MaxLabel_Diff.TabIndex = 20;
            this.MaxLabel_Diff.Text = "Max";
            // 
            // MinLabel_Diff
            // 
            this.MinLabel_Diff.AutoSize = true;
            this.MinLabel_Diff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MinLabel_Diff.Location = new System.Drawing.Point(2425, 570);
            this.MinLabel_Diff.Name = "MinLabel_Diff";
            this.MinLabel_Diff.Size = new System.Drawing.Size(36, 18);
            this.MinLabel_Diff.TabIndex = 21;
            this.MinLabel_Diff.Text = "Min";
            // 
            // AvgLabel_Diff
            // 
            this.AvgLabel_Diff.AutoSize = true;
            this.AvgLabel_Diff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AvgLabel_Diff.Location = new System.Drawing.Point(2425, 402);
            this.AvgLabel_Diff.Name = "AvgLabel_Diff";
            this.AvgLabel_Diff.Size = new System.Drawing.Size(40, 18);
            this.AvgLabel_Diff.TabIndex = 26;
            this.AvgLabel_Diff.Text = "Avg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(1877, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "(PSNR: )";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2517, 635);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AvgLabel_Diff);
            this.Controls.Add(this.AvgLabel_Comp);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ColorBar_Diff);
            this.Controls.Add(this.MinLabel_Diff);
            this.Controls.Add(this.MaxLabel_Diff);
            this.Controls.Add(this.MinLabel_Comp);
            this.Controls.Add(this.MaxLabel_Comp);
            this.Controls.Add(this.ColorBar_Comp);
            this.Controls.Add(this.MinLabel_Ref);
            this.Controls.Add(this.AvgLabel_Ref);
            this.Controls.Add(this.MaxLabel_Ref);
            this.Controls.Add(this.ColorBar_Ref);
            this.Controls.Add(this.pictureBox_Diff);
            this.Controls.Add(this.pictureBox_Comp);
            this.Controls.Add(this.pictureBox_Ref);
            this.Controls.Add(this.OpenColorSetting);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Data Map 비교";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ref)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Diff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBar_Ref)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBar_Comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBar_Diff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RefPath_TextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox CompPath_TextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button OpenColorSetting;
        private System.Windows.Forms.PictureBox pictureBox_Diff;
        private System.Windows.Forms.PictureBox pictureBox_Comp;
        private System.Windows.Forms.PictureBox pictureBox_Ref;
        private System.Windows.Forms.PictureBox ColorBar_Ref;
        private System.Windows.Forms.Label MinLabel_Ref;
        private System.Windows.Forms.Label MaxLabel_Ref;
        private System.Windows.Forms.PictureBox ColorBar_Diff;
        private System.Windows.Forms.Label MinLabel_Comp;
        private System.Windows.Forms.Label MaxLabel_Comp;
        private System.Windows.Forms.PictureBox ColorBar_Comp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label AvgLabel_Ref;
        private System.Windows.Forms.Label AvgLabel_Diff;
        private System.Windows.Forms.Label AvgLabel_Comp;
        private System.Windows.Forms.Label MinLabel_Diff;
        private System.Windows.Forms.Label MaxLabel_Diff;
        private System.Windows.Forms.Label label7;
    }
}

