using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_TEST
{
    public partial class Main : Form
    {
        private string RefFilePath = "";
        private string CompFilePath = "";
        private bool RefFileOpen = false;
        private bool CompFileOpen = false;
        private double[,] RefArray;
        private double[,] CompArray;
        private double[,] DiffArray;

        private Color HighValueColor;
        private Color LowValueColor;
        private Color AvgValueColor;
        // ColorSetting에 의해 변조 가능
        public string[] MaxColor;
        public string[] MinColor;
        public string[] AvgColor;
        public int DefaultManualConfig;

        public Main()
        {
            InitializeComponent();
            MaxColor = new string[] { "219", "77", "55" };
            MinColor = new string[] { "35", "65", "159" };
            AvgColor = new string[] { "255", "255", "255" };
        }

        public void HeatMapGen(object sender, EventArgs e)
        {
            HighValueColor = Color.FromArgb(255, Convert.ToInt16(MaxColor[0]), Convert.ToInt16(MaxColor[1]), Convert.ToInt16(MaxColor[2]));
            LowValueColor = Color.FromArgb(255, Convert.ToInt16(MinColor[0]), Convert.ToInt16(MinColor[1]), Convert.ToInt16(MinColor[2]));
            AvgValueColor = Color.FromArgb(255, Convert.ToInt16(AvgColor[0]), Convert.ToInt16(AvgColor[1]), Convert.ToInt16(AvgColor[2]));

            if (!((RefFileOpen)&&(CompFileOpen)))
            {
                MessageBox.Show("Error: 설정된 경로에 파일이 없습니다 // 파일을 불러오십시오.");
            }
            else
            {
                if ((RefArray.GetLength(0) == CompArray.GetLength(0)) && (RefArray.GetLength(1) == CompArray.GetLength(1)))
                {
                    DiffArray = Calc.SubAfromB<double>(CompArray, RefArray);
                    CreateBitmap(pictureBox_Ref, RefArray);                    
                    CreateBitmap(pictureBox_Comp, CompArray);
                    CreateBitmap(pictureBox_Diff, DiffArray);

                    SetColorBar(ColorBar_Ref, RefArray, MaxLabel_Ref, MinLabel_Ref, AvgLabel_Ref);
                    SetColorBar(ColorBar_Comp, RefArray, MaxLabel_Comp, MinLabel_Comp, AvgLabel_Comp);
                    SetColorBar(ColorBar_Diff, RefArray, MaxLabel_Diff, MinLabel_Diff, AvgLabel_Diff);
                }
                else
                {
                    MessageBox.Show("Error: 비교할 데이터의 크기가 다릅니다.");
                    RefPath_TextBox.Clear(); CompPath_TextBox.Clear();
                    RefFileOpen = false;
                    RefFileOpen = false;
                }
            }            
        }
        private void OpenRef_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "파일 선택";
            openFileDialog.Filter = "CSV 파일 (*.csv)|*.csv|모든 파일 (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.RefFilePath = openFileDialog.FileName;
                    //MessageBox.Show($"불러오기 완료: {this.RefFilePath}");
                    RefFileOpen = true;
                    RefPath_TextBox.Text = this.RefFilePath;
                    RefArray = Calc.CsvRead<double>(this.RefFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message + " 경로를 다시 확인하세요.");
                    RefPath_TextBox.Clear();
                }
            }
        }

        private void OpenComp_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "파일 선택";
            openFileDialog.Filter = "CSV 파일 (*.csv)|*.csv|모든 파일 (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.CompFilePath = openFileDialog.FileName;
                    //MessageBox.Show($"불러오기 완료: {this.CompFilePath}");
                    CompFileOpen = true;
                    CompPath_TextBox.Text = this.CompFilePath;
                    CompArray = Calc.CsvRead<double>(this.CompFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message + " 경로를 다시 확인하세요.");
                    CompPath_TextBox.Clear();
                }
            }
        }

        private void CreateBitmap(PictureBox pictureBox, double[,] data)
        {
            int RowNum = data.GetLength(0);
            int ColNum = data.GetLength(1);

            int PixelSizeV = (int)(pictureBox.Height / RowNum);
            int PixelSizeH = (int)(pictureBox.Width / ColNum);

            double MaxValue = Calc.Convert1Dfrom2D<double>(data).Max();
            double MinValue = Calc.Convert1Dfrom2D<double>(data).Min();
            double AvgValue = Calc.Convert1Dfrom2D<double>(data).Average();

            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            Font customFont = new Font("ArialNarrow", 9);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                for (int y = 0; y < RowNum; y++)
                {
                    for (int x = 0; x < ColNum; x++)
                    {
                        // 색상 설정                        
                        Brush custum = new SolidBrush(ColorScaling(data[y, x], MaxValue, MinValue, AvgValue, HighValueColor, LowValueColor, AvgValueColor));

                        // 픽셀 그리기
                        g.FillRectangle(custum, x * PixelSizeH, y * PixelSizeV, PixelSizeH, PixelSizeV);

                        //// 글자 설정
                        //string text = data[y, x].ToString("0.00");
                        //SizeF textSize = g.MeasureString(text, customFont);

                        //// 글자 그리기
                        //float textX = (x * PixelSizeH) + ((PixelSizeH - textSize.Width) / 2);
                        //float textY = (y * PixelSizeV) + ((PixelSizeV - textSize.Height) / 2);

                        //g.DrawString(text, customFont, Brushes.Black, textX, textY);
                    }
                    //int ttt = 0;
                }
            }

            pictureBox.Image = bitmap;
        }

        private void SetColorBar(PictureBox pictureBox, double[,] data, Label Max, Label Min, Label Avg)
        {
            int RowNum = data.GetLength(0);
            int ColNum = data.GetLength(1);

            int PixelSizeV = (int)(pictureBox.Height / RowNum);
            int PixelSizeH = (int)(pictureBox.Width);

            double MaxValue = Calc.Convert1Dfrom2D<double>(data).Max();
            double MinValue = Calc.Convert1Dfrom2D<double>(data).Min();
            double AvgValue = Calc.Convert1Dfrom2D<double>(data).Average();

            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                for (int y = 0; y < RowNum; y++)
                {
                    double value = MaxValue - (((MaxValue - MinValue) * y) / RowNum);
                    Brush custum = new SolidBrush(ColorScaling(value, MaxValue, MinValue, AvgValue, HighValueColor, LowValueColor, AvgValueColor));
                    g.FillRectangle(custum, 0, y * PixelSizeV, pictureBox.Width, PixelSizeV);
                }
            }

            pictureBox.Image = bitmap;

            Max.Text = "Max: " + MaxValue.ToString("F2");
            Min.Text = "Min: " + MinValue.ToString("F2");
            Avg.Text = "Avg: " + AvgValue.ToString("F2");

        }

        private static Color ColorScaling(double Value, double MaxVal, double MinVal, double AvgVal, Color HighColor, Color LowColor, Color AvgColor)
        {
            int r = 0; int g = 0; int b = 0;
            if (Value > AvgVal)
            {
                r = (int)(((Value - AvgVal) / (MaxVal - AvgVal)) * (HighColor.R - AvgColor.R) + AvgColor.R);
                g = (int)(((Value - AvgVal) / (MaxVal - AvgVal)) * (HighColor.G - AvgColor.G) + AvgColor.G);
                b = (int)(((Value - AvgVal) / (MaxVal - AvgVal)) * (HighColor.B - AvgColor.B) + AvgColor.B);
            }
            else if (Value < AvgVal)
            {
                r = (int)(((Value - AvgVal) / (MinVal - AvgVal)) * (LowColor.R - AvgColor.R) + AvgColor.R);
                g = (int)(((Value - AvgVal) / (MinVal - AvgVal)) * (LowColor.G - AvgColor.G) + AvgColor.G);
                b = (int)(((Value - AvgVal) / (MinVal - AvgVal)) * (LowColor.B - AvgColor.B) + AvgColor.B);
            }
            else if (Value == AvgVal)
            {
                r = AvgColor.R;
                g = AvgColor.G;
                b = AvgColor.B;
            }
           
            return System.Drawing.Color.FromArgb(255, r, g, b);
        }

        private void OpenColorSetting_Click(object sender, EventArgs e)
        {
            ColorSetting cs = new ColorSetting(DefaultManualConfig, MaxColor, MinColor, AvgColor);
            cs.Owner = this;
            cs.ShowDialog();
        }
        public void ApplySettingChange(string[] Max, string[] Min, string[] Avg, int Config)
        {
            this.MaxColor = Max;
            this.MinColor = Min;
            this.AvgColor = Avg;
            this.DefaultManualConfig = Config;
         }
    }
}
