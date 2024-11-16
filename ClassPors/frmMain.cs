using ClassPors.Tables;
using System;
using System.Windows.Forms;

namespace ClassPors
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            LoadControls();
        }

        private void LoadControls()
        {
            lblCaption.Text = CPorsControl.Title;
            btnGood.Text = CPorsControl.Btn1;
            btnNorm.Text = CPorsControl.Btn2;
            btnBad.Text = CPorsControl.Btn3;

            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.btnGood, "از عدد 1 در صفحه کلید هم می توانید استفاده کنید");
            toolTip1.SetToolTip(this.btnNorm, "از عدد 2 در صفحه کلید هم می توانید استفاده کنید");
            toolTip1.SetToolTip(this.btnBad, "از عدد 3 در صفحه کلید هم می توانید استفاده کنید");

        }
        private void btnGood_Click(object sender, EventArgs e)
        {
            CPors.Good++;
            CPors.Total++;
        }
        private void btnNorm_Click(object sender, EventArgs e)
        {
            CPors.Norm++;
            CPors.Total++;
            //lineChanger("new content for this line", path, 10);
        }
        private void btnBad_Click(object sender, EventArgs e)
        {
            CPors.Bad++;
            CPors.Total++;
            /*
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(path);
                //Read the first line of text
                line = sr.ReadLine();

                string linex = File.ReadLines(path).Skip(9).Take(1).First();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            */
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                btnGood_Click(null, null);
            }
            else
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                btnNorm_Click(null, null);
            }
            else
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                btnBad_Click(null, null);
            }
        }
    }
}
