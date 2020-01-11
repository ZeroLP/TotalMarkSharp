using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using TotalMarkSharp.Modules;

namespace TotalMarkSharp
{
    public partial class Main : Form
    {
        public Main()
        {
            Thread T = new Thread(new ThreadStart(LoadSplashView));
            T.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            T.Abort();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitialiseDesign();
        }

        void LoadSplashView()
        {
            Application.Run(new ViewModels.Splash());
        }

        void InitialiseDesign()
        {
            Color MenuColour = Color.FromArgb(42, 54, 97);
            Color TransparentColor = Color.FromArgb(0, 255, 255, 255);

            Region = Region.FromHrgn(NativeImport.CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

            CloseButton.BackColor = MenuColour;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.BorderColor = TransparentColor;

            MinimiseButton.BackColor = MenuColour;
            MinimiseButton.FlatAppearance.BorderSize = 0;
            MinimiseButton.FlatAppearance.BorderColor = TransparentColor;
        }

        private void MenuBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeImport.ReleaseCapture();
                NativeImport.SendMessage(Handle, NativeImport.WM_NCLBUTTONDOWN, NativeImport.HTCAPTION, 0);
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TotalOneMarkBox.Text) || string.IsNullOrEmpty(TotalOneMarkAnswerdBox.Text) || string.IsNullOrEmpty(TotalTwoMarksBox.Text) || string.IsNullOrEmpty(TotalTwoMarksAnsweredBox.Text)) { ErrorText.Text = "Please Fill In Every Box"; return; }
            if (int.TryParse(TotalOneMarkBox.Text, out int Res) == false || int.TryParse(TotalOneMarkAnswerdBox.Text, out int Res2) == false || int.TryParse(TotalTwoMarksBox.Text, out int Res3) == false || int.TryParse(TotalTwoMarksAnsweredBox.Text, out int Res4) == false) { ErrorText.Text = "Please Enter A Valid Number"; return; }
            if (int.Parse(TotalOneMarkBox.Text) < 0 || int.Parse(TotalOneMarkAnswerdBox.Text) < 0 || int.Parse(TotalTwoMarksBox.Text) < 0 || int.Parse(TotalTwoMarksAnsweredBox.Text) < 0) { ErrorText.Text = "Marks Cannot Be Negative Value"; return; }
            if (Calculator.Calculate(int.Parse(TotalOneMarkBox.Text), int.Parse(TotalOneMarkAnswerdBox.Text), int.Parse(TotalTwoMarksBox.Text), int.Parse(TotalTwoMarksAnsweredBox.Text)) == null) { ErrorText.Text = "Total Marks Are More Than The Available Mark"; return; }
            
            int[] CalculatedValues = Calculator.Calculate(int.Parse(TotalOneMarkBox.Text), int.Parse(TotalOneMarkAnswerdBox.Text), int.Parse(TotalTwoMarksBox.Text), int.Parse(TotalTwoMarksAnsweredBox.Text));

            TotalMarkText.Text = $"Total Marks: {CalculatedValues[0].ToString()}";
            TotalMarksAvailText.Text = $"Total Marks Available: {CalculatedValues[1].ToString()}";
            MarkPercentageText.Text = $"Percentage: {CalculatedValues[2].ToString()}%";
        }

        private void MinimiseButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
