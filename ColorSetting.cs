using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GUI_TEST
{
    public partial class ColorSetting : Form
    {
        //private Color HighValue;
        //private Color LowValue;
        private string[] MaxColorDefault = new string[] { "219", "77", "55" };
        private string[] MinColorDefault = new string[] { "35", "65", "159" };
        private string[] AvgColorDefault = new string[] { "255", "255", "255" };
        public int DefaultManualConfig;

        public ColorSetting(int DefaultManualConfig, string[] MaxVal, string[] MinVal, string[] AvgVal)
        {
            string[] MaxColor = new string[3];
            string[] MinColor = new string[3];
            string[] AvgColor = new string[3];
            InitializeComponent();
            if (DefaultManualConfig == 0)
            {
                MaxColor = MaxColorDefault;
                MinColor = MinColorDefault;
                AvgColor = AvgColorDefault;
                checkBox_DefaultColor.Checked = true;                
            }
            else if (DefaultManualConfig == 1)
            {
                MaxColor = MaxVal;
                MinColor = MinVal;
                AvgColor = AvgVal;
                checkBox_DefaultColor.Checked = false;
            }
           
            TextBox_RMAX.Text = MaxColor[0]; TextBox_GMAX.Text = MaxColor[1]; TextBox_BMAX.Text = MaxColor[2];
            TextBox_RMIN.Text = MinColor[0]; TextBox_GMIN.Text = MinColor[1]; TextBox_BMIN.Text = MinColor[2];
            TextBox_RAVG.Text = AvgColor[0]; TextBox_GAVG.Text = AvgColor[1]; TextBox_BAVG.Text = AvgColor[2];
        }

        private static bool CheckIntOrNot(TextBox Box)
        {
            if (int.TryParse(Box.Text, out int Result) == false)
            {
                //MessageBox.Show("0에서 255 사이의 숫자를 입력하세요");
                Box.Clear();
                return false;
            }
            else
            {
                if ((Result >= 0) && (Result <= 255))
                {
                    return true;
                }
                else
                {
                    //MessageBox.Show("0에서 255 사이의 숫자를 입력하세요");
                    Box.Clear();
                    return false;
                }
            }
        }
        private void checkBox_DefaultColor_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_DefaultColor.Checked == true)
            {
                checkBox_ManualColor.Checked = false;
                TextBox_RMAX.Text = MaxColorDefault[0]; TextBox_GMAX.Text = MaxColorDefault[1]; TextBox_BMAX.Text = MaxColorDefault[2];
                TextBox_RMIN.Text = MinColorDefault[0]; TextBox_GMIN.Text = MinColorDefault[1]; TextBox_BMIN.Text = MinColorDefault[2];
                TextBox_RAVG.Text = MinColorDefault[0]; TextBox_GAVG.Text = MinColorDefault[1]; TextBox_BAVG.Text = MinColorDefault[2];
                DefaultManualConfig = 0;
    }
            else if (checkBox_DefaultColor.Checked == false)
            {
                checkBox_ManualColor.Checked = true;
                TextBox_RMAX.Clear(); TextBox_GMAX.Clear(); TextBox_BMAX.Clear();
                TextBox_RMIN.Clear(); TextBox_GMIN.Clear(); TextBox_BMIN.Clear();
                TextBox_RAVG.Clear(); TextBox_GAVG.Clear(); TextBox_BAVG.Clear();
                DefaultManualConfig = 1;
            }
        }

        private void checkBox_ManualColor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ManualColor.Checked == true)
            {
                checkBox_DefaultColor.Checked = false;
                TextBox_RMAX.Clear(); TextBox_GMAX.Clear(); TextBox_BMAX.Clear();
                TextBox_RMIN.Clear(); TextBox_GMIN.Clear(); TextBox_BMIN.Clear();
                TextBox_RAVG.Clear(); TextBox_GAVG.Clear(); TextBox_BAVG.Clear();
                DefaultManualConfig = 1;
            }
            else if (checkBox_ManualColor.Checked == false)
            {
                checkBox_DefaultColor.Checked = true;
                TextBox_RMAX.Text = MaxColorDefault[0]; TextBox_GMAX.Text = MaxColorDefault[1]; TextBox_BMAX.Text = MaxColorDefault[2];
                TextBox_RMIN.Text = MaxColorDefault[0]; TextBox_GMIN.Text = MaxColorDefault[1]; TextBox_BMIN.Text = MaxColorDefault[2];
                TextBox_RAVG.Text = MinColorDefault[0]; TextBox_GAVG.Text = MinColorDefault[1]; TextBox_BAVG.Text = MinColorDefault[2];
                DefaultManualConfig = 0;
            }
        }

        private void ColorSetButton_Click(object sender, EventArgs e)
        {
            string[] High = new string[3];
            string[] Low = new string[3];
            string[] Avg = new string[3];
            if (checkBox_ManualColor.Checked == true)
            {
                if (!(
                        CheckIntOrNot(TextBox_RMAX) &&
                        CheckIntOrNot(TextBox_GMAX) &&
                        CheckIntOrNot(TextBox_BMAX) &&
                        CheckIntOrNot(TextBox_RMIN) &&
                        CheckIntOrNot(TextBox_GMIN) &&
                        CheckIntOrNot(TextBox_BMIN) &&
                        CheckIntOrNot(TextBox_RAVG) &&
                        CheckIntOrNot(TextBox_GAVG) &&
                        CheckIntOrNot(TextBox_BAVG)))
                {
                    MessageBox.Show("0에서 255 사이의 숫자를 입력하세요");
                    TextBox_RMAX.Clear(); TextBox_GMAX.Clear(); TextBox_BMAX.Clear();
                    TextBox_RMIN.Clear(); TextBox_GMIN.Clear(); TextBox_BMIN.Clear();
                    TextBox_RAVG.Clear(); TextBox_GAVG.Clear(); TextBox_BAVG.Clear();
                }
                else
                {
                    High[0] = TextBox_RMAX.Text; High[1] = TextBox_GMAX.Text; High[2] = TextBox_BMAX.Text;
                    Low[0] = TextBox_RMIN.Text; Low[1] = TextBox_GMIN.Text; Low[2] = TextBox_BMIN.Text;
                    Avg[0] = TextBox_RAVG.Text; Avg[1] = TextBox_GAVG.Text; Avg[2] = TextBox_BAVG.Text;

                    ((Main)this.Owner).ApplySettingChange(High, Low, Avg, DefaultManualConfig);
                    this.Close();
                }

            }
            // Defalt Color
            else if (checkBox_ManualColor.Checked == false)
            {
                High = MaxColorDefault;
                Low = MinColorDefault;
                Avg = AvgColorDefault;

                ((Main)this.Owner).ApplySettingChange(High, Low, Avg, DefaultManualConfig);
                this.Close();
            }            
        }
    }
}
