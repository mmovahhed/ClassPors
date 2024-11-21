using ClassPors.Tables;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassPors
{
    public partial class frmMainMDI : Form
    {
        static string path = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath).ToString() + @"\\dbText.txt";
        static string pathControls = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath).ToString() + @"\\dbControls.txt";
        public frmMainMDI()
        {
            InitializeComponent();
            LoadControlsTitles();
        }

        private void LoadControlsTitles()
        {
            try
            {

                string str = File.ReadLines(pathControls).Skip(0).Take(1).First();
                CPorsControl.Title = str.Split(new[] { "Title=" }, StringSplitOptions.None)[1];

                str = File.ReadLines(pathControls).Skip(1).Take(2).First();
                CPorsControl.Btn1 = str.Split(new[] { "Btn1=" }, StringSplitOptions.None)[1];

                str = File.ReadLines(pathControls).Skip(2).Take(3).First();
                CPorsControl.Btn2 = str.Split(new[] { "Btn2=" }, StringSplitOptions.None)[1];

                str = File.ReadLines(pathControls).Skip(3).Take(4).First();
                CPorsControl.Btn3 = str.Split(new[] { "Btn3=" }, StringSplitOptions.None)[1];

            }
            catch (Exception ex)
            {
                MessageBox.Show("ErrLn40: " + ex.ToString());
            }
        }

        private void menuShowPoll_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmGrid")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }

            }
            if (!IsOpen)
            {
                frmGrid _frmGrid = new frmGrid();
                _frmGrid.MdiParent = this;
                _frmGrid.Dock = DockStyle.Fill;
                _frmGrid.Show();
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void menuResetFile_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("آیا از پاک کردن فایل آماری ذخیره شده اطمینان دارید؟", "پاک کردن فایل آمار", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (resetFile())
                {
                    MessageBox.Show("نوسازی فایل با موفقیت انجام شد!");
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.Name == "frmMain")
                        {
                            form.Visible = false;
                            form.Dispose();
                            frmMain _frmMain = new frmMain();
                            _frmMain.MdiParent = this;
                            _frmMain.Dock = DockStyle.Fill;
                            _frmMain.Show();
                            break;
                        }
                        if (form.Name == "frmGrid")
                        {
                            form.Visible = false;
                            form.Dispose();
                            frmGrid _frmGrid = new frmGrid();
                            _frmGrid.MdiParent = this;
                            _frmGrid.Dock = DockStyle.Fill;
                            _frmGrid.Show();
                            break;
                        }
                    }
                }
                else
                    MessageBox.Show("نوسازی فایل با خطا مواجه شد! لطفا دوباره تلاش کنید!");
            }


        }

        bool resetFile()
        {
            try
            {

                File.Create(path).Close();

                StreamWriter sw = new StreamWriter(path, true, Encoding.ASCII);

                sw.WriteLine("G=" + (CPors.Good = 0));
                sw.WriteLine("N=" + (CPors.Norm = 0));
                sw.WriteLine("B=" + (CPors.Bad = 0));
                sw.WriteLine("T=" + (CPors.Total = 0));

                //close the file
                sw.Close();
                return true;
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

        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        private void menuLoadFile_Click(object sender, EventArgs e)
        {
            try
            {
                CPors.Good = Convert.ToInt32(File.ReadLines(path).Skip(0).Take(1).First().Split('=')[1]);
                CPors.Norm = Convert.ToInt32(File.ReadLines(path).Skip(1).Take(2).First().Split('=')[1]);
                CPors.Bad = Convert.ToInt32(File.ReadLines(path).Skip(2).Take(3).First().Split('=')[1]);
                CPors.Total = Convert.ToInt32(File.ReadLines(path).Skip(3).Take(4).First().Split('=')[1]);

                MessageBox.Show("بارگیری فایل در برنامه با موفقیت انجام شد!");
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "frmMain")
                    {
                        form.Visible = false;
                        form.Dispose();
                        frmMain _frmMain = new frmMain();
                        _frmMain.MdiParent = this;
                        _frmMain.Dock = DockStyle.Fill;
                        _frmMain.Show();
                        break;
                    }
                    if (form.Name == "frmGrid")
                    {
                        form.Visible = false;
                        form.Dispose();
                        frmGrid _frmGrid = new frmGrid();
                        _frmGrid.MdiParent = this;
                        _frmGrid.Dock = DockStyle.Fill;
                        _frmGrid.Show();
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ErrLn156: " + ex.ToString());
            }
        }

        private void frmMainMDI_FormClosed(object sender, FormClosedEventArgs e)
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

        private void menuPoll_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Visible = false;
                form.Dispose();
            }
            frmMain _frmMain = new frmMain();
            _frmMain.MdiParent = this;
            _frmMain.Dock = DockStyle.Fill;
            _frmMain.StartPosition = FormStartPosition.CenterParent;
            _frmMain.Show();
        }

        private void menuEditPollTitle_Click(object sender, EventArgs e)
        {
            editContols(0);
        }


        private void menuEditBtn1_Click(object sender, EventArgs e)
        {
            editContols(1);
        }

        private void menuEditBtn2_Click(object sender, EventArgs e)
        {
            editContols(2);
        }

        private void menuEditBtn3_Click(object sender, EventArgs e)
        {
            editContols(3);
        }

        private void editContols(int cntrl)
        {
            try
            {
                bool editFlag = false;
                switch (cntrl)
                {
                    case 0:
                        {
                            string input = CPorsControl.Title;
                            if (ShowInputDialog(ref input) == DialogResult.OK && CPorsControl.Title.Trim() != input.Trim())
                            {
                                lineChanger("Title=" + input.Trim(), pathControls, cntrl + 1);
                                CPorsControl.Title = input;
                                editFlag = true;
                            }
                            break;
                        }
                    case 1:
                        {
                            string input = CPorsControl.Btn1;
                            if (ShowInputDialog(ref input) == DialogResult.OK && CPorsControl.Btn1.Trim() != input.Trim())
                            {
                                lineChanger("Btn1=" + input.Trim(), pathControls, cntrl + 1);
                                CPorsControl.Btn1 = input;
                                editFlag = true;
                            }
                            break;
                        }
                    case 2:
                        {
                            string input = CPorsControl.Btn2;
                            if (ShowInputDialog(ref input) == DialogResult.OK && CPorsControl.Btn2.Trim() != input.Trim())
                            {
                                lineChanger("Btn2=" + input.Trim(), pathControls, cntrl + 1);
                                CPorsControl.Btn2 = input;
                                editFlag = true;
                            }
                            break;
                        }
                    case 3:
                        {
                            string input = CPorsControl.Btn3;
                            if (ShowInputDialog(ref input) == DialogResult.OK && CPorsControl.Btn3.Trim() != input.Trim())
                            {
                                lineChanger("Btn3=" + input.Trim(), pathControls, cntrl + 1);
                                CPorsControl.Btn3 = input;
                                editFlag = true;
                            }
                            break;
                        }
                    default:
                        break;
                }
                if (editFlag)
                {
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.Name == "frmMain")
                        {
                            form.Visible = false;
                            form.Dispose();
                            frmMain _frmMain = new frmMain();
                            _frmMain.MdiParent = this;
                            _frmMain.Dock = DockStyle.Fill;
                            _frmMain.Show();
                            break;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ErrLn201: " + ex.ToString());
            }
        }

        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 80);
            Form inputBox = new Form();
            System.Drawing.Size _newSize = new System.Drawing.Size(75, 30);
            System.Drawing.Font _newFont = new System.Drawing.Font("B Titr", 10f);

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "ویرایش";
            inputBox.StartPosition = FormStartPosition.CenterParent;
            inputBox.RightToLeft = RightToLeft.Yes;

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 25);
            textBox.Font = _newFont;
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = _newSize;
            okButton.Text = "&ثبت";
            okButton.Font = _newFont;
            okButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = _newSize;
            cancelButton.Text = "&انصراف";
            cancelButton.Font = _newFont;
            cancelButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }
    }
}
