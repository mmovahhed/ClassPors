using ClassPors.Tables;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassPors
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            frmGrid fg = new frmGrid();
            fg.ShowDialog();

        }

        static string path = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath).ToString() + @"\\dbText.txt";
        //CPors cPors = new CPors();

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

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetFile();
            MessageBox.Show("نوسازی فایل با موفقیت انجام شد!");
        }

        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        bool saveInFile()
        {
            try
            {
                File.Create(path).Close();
                StreamWriter sw = new StreamWriter(path, true, Encoding.ASCII);

                sw.WriteLine("G=" + CPors.Good);
                sw.WriteLine("N=" + CPors.Norm);
                sw.WriteLine("B=" + CPors.Bad);
                sw.WriteLine("T=" + CPors.Total);

                //close the file
                sw.Close();

                MessageBox.Show("ذخیره سازی در فایل با موفقیت انجام شد!");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception110: " + ex.Message);
                return false;
            }


        }

        bool resetFile()
        {
            try
            {

                File.Create(path).Close();

                StreamWriter sw = new StreamWriter(path, true, Encoding.ASCII);

                sw.WriteLine("G=" + CPors.Good);
                sw.WriteLine("N=" + CPors.Norm);
                sw.WriteLine("B=" + CPors.Bad);
                sw.WriteLine("T=" + CPors.Total);

                //close the file
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception136: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.140");
            }
            return false;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            try
            {
                CPors.Good = Convert.ToInt32(File.ReadLines(path).Skip(0).Take(1).First().Split('=')[1]);
                CPors.Norm = Convert.ToInt32(File.ReadLines(path).Skip(1).Take(2).First().Split('=')[1]);
                CPors.Bad = Convert.ToInt32(File.ReadLines(path).Skip(2).Take(3).First().Split('=')[1]);
                CPors.Total = Convert.ToInt32(File.ReadLines(path).Skip(3).Take(4).First().Split('=')[1]);

                MessageBox.Show("بارگیری فایل در برنامه با موفقیت انجام شد!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("156: " + ex.ToString());
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("آیا تمایل دارید که این جلسه در فایل ذخیره شود؟", "ذخیره در فایل", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (saveInFile())
                    Application.Exit();
                else
                    MessageBox.Show("خطا در ذخیره فایل");
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit();
            }
        }
    }
}
