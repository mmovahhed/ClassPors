using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ClassPors.Tools
{
    public class Helper
    {
        public static DataTable ToADOTable<T>(IEnumerable<T> varlist)
        {
            DataTable dtReturn = new DataTable();
            // Use reflection to get property names, to create table
            // column names
            PropertyInfo[] oProps = typeof(T).GetProperties();
            foreach (PropertyInfo pi in oProps)
            {
                Type colType = pi.PropertyType;
                if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                    colType = colType.GetGenericArguments()[0];
                dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
            }
            foreach (T rec in varlist)
            {
                DataRow dr = dtReturn.NewRow();
                foreach (PropertyInfo pi in oProps)
                    dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue(rec, null);
                dtReturn.Rows.Add(dr);
            }

            return (dtReturn);
        }
        public struct ValidateType
        {
            static private string Digit = "Digit";
            static private string String = "String";
            static private string Combo = "Combo";
        }

        public static void ClearFormControls(UserControl form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txtbox = (TextBox)control;
                    txtbox.Text = String.Empty;
                }
                else if (control is CheckBox)
                {
                    CheckBox chkbox = (CheckBox)control;
                    chkbox.Checked = false;
                }
                else if (control is RadioButton)
                {
                    RadioButton rdbtn = (RadioButton)control;
                    rdbtn.Checked = false;
                }
                else if (control is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)control;
                    dtp.Value = DateTime.Now;
                }
            }
        }

        public static void ClearFormControls(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txtbox = (TextBox)control;
                    txtbox.Text = String.Empty;
                }
                else if (control is GroupBox)
                {
                    GroupBox grpbox = (GroupBox)control;
                    ClearFormControls(grpbox);
                }
                else if (control is CheckBox)
                {
                    CheckBox chkbox = (CheckBox)control;
                    chkbox.Checked = false;
                }
                else if (control is RadioButton)
                {
                    RadioButton rdbtn = (RadioButton)control;
                    rdbtn.Checked = false;
                }
                else if (control is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)control;
                    dtp.Value = DateTime.Now;
                }
            }
        }

        public static void ClearFormControls(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txtbox = (TextBox)control;
                    txtbox.Text = String.Empty;
                }
                else if (control is GroupBox)
                {
                    GroupBox grpbox = (GroupBox)control;
                    ClearFormControls(grpbox);
                }
                else if (control is CheckBox)
                {
                    CheckBox chkbox = (CheckBox)control;
                    chkbox.Checked = false;
                }
                else if (control is RadioButton)
                {
                    RadioButton rdbtn = (RadioButton)control;
                    rdbtn.Checked = false;
                }
                else if (control is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)control;
                    dtp.Value = DateTime.Now;
                }
            }
        }

        public static bool ControlValidation(UserControl form)
        {
            foreach (Control control in form.Controls)
            {
                control.ResetBackColor();
            }
            //bool result = false;
            foreach (Control control in form.Controls)
            {
                if (control.Visible && control.Enabled)
                {
                    if (control is TextBox)
                    {
                        TextBox txtbox = (TextBox)control;

                        if (!txtbox.ReadOnly && txtbox.Tag != null)
                        {
                            if (!String.IsNullOrEmpty(txtbox.Text))
                            {
                                switch (control.Tag.ToString())
                                {
                                    case "Digit":
                                        {
                                            if (!IsNumeric(txtbox.Text))
                                            {
                                                txtbox.BackColor = Color.Khaki;
                                                //ChangeBorder(txtbox,Color.Red);
                                                return false;
                                            }
                                            txtbox.ResetBackColor();
                                        }
                                        break;
                                    case "String":
                                        {
                                            if (txtbox.Text.Trim().Any(ch => !Char.IsLetterOrDigit(ch) && !Char.IsWhiteSpace(ch)))
                                            {
                                                txtbox.BackColor = Color.Khaki;
                                                return false;
                                            }
                                            txtbox.ResetBackColor();
                                        }
                                        break;
                                    case "Date":
                                        ;
                                        break;
                                    case "DateTime":
                                        ;
                                        break;
                                    case "Email":
                                        ;
                                        break;
                                    default:
                                        break;

                                }
                            }
                            else
                            {
                                txtbox.BackColor = Color.Khaki;
                                return false;
                            }
                        }


                    }
                    else if (control is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        if (comboBox.Items.Count == 0 || String.IsNullOrEmpty(comboBox.Text))
                        {
                            comboBox.BackColor = Color.Khaki;
                            return false;
                        }
                        comboBox.ResetBackColor();
                    }
                    //else if (control is CheckBox)
                    //{
                    //    CheckBox chkbox = (CheckBox) control;
                    //    chkbox.Checked = false;
                    //}
                    //else if (control is RadioButton)
                    //{
                    //    RadioButton rdbtn = (RadioButton) control;
                    //    rdbtn.Checked = false;
                    //}
                    //else if (control is DateTimePicker)
                    //{
                    //    DateTimePicker dtp = (DateTimePicker) control;
                    //    dtp.Value = DateTime.Now;
                    //}

                }
            }
            return true;
        }

        public static bool ControlValidation(Form form)
        {
            foreach (Control control in form.Controls)
            {
                control.ResetBackColor();
            }
            foreach (Control control in form.Controls)
            {
                if (control.Visible && control.Enabled)
                {
                    if (control is TextBox)
                    {
                        TextBox txtbox = (TextBox)control;

                        if (!txtbox.ReadOnly && !String.IsNullOrEmpty(txtbox.Tag.ToString()))
                        {
                            if (!txtbox.ReadOnly && txtbox.Tag != null)
                            {
                                switch (control.Tag.ToString())
                                {
                                    case "Digit":
                                        {
                                            if (!IsNumeric(txtbox.Text))
                                            {
                                                txtbox.BackColor = Color.Khaki;
                                                return false;
                                            }
                                            txtbox.ResetBackColor();
                                        }
                                        break;
                                    case "String":
                                        {
                                            if (txtbox.Text.Trim().Any(ch => !Char.IsLetterOrDigit(ch) && !Char.IsWhiteSpace(ch)))
                                            {
                                                txtbox.BackColor = Color.Khaki;
                                                return false;
                                            }
                                            txtbox.ResetBackColor();
                                        }
                                        break;
                                    case "Date":
                                        ;
                                        break;
                                    case "DateTime":
                                        ;
                                        break;
                                    case "Email":
                                        ;
                                        break;
                                    default:
                                        break;

                                }
                            }
                            else
                            {
                                txtbox.BackColor = Color.Khaki;
                                return false;
                            }
                        }


                    }
                    else if (control is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        if (comboBox.Items.Count == 0 || String.IsNullOrEmpty(comboBox.Text))
                        {
                            comboBox.BackColor = Color.Khaki;
                            return false;
                        }
                        comboBox.ResetBackColor();
                    }
                    //else if (control is CheckBox)
                    //{
                    //    CheckBox chkbox = (CheckBox) control;
                    //    chkbox.Checked = false;
                    //}
                    //else if (control is RadioButton)
                    //{
                    //    RadioButton rdbtn = (RadioButton) control;
                    //    rdbtn.Checked = false;
                    //}
                    //else if (control is DateTimePicker)
                    //{
                    //    DateTimePicker dtp = (DateTimePicker) control;
                    //    dtp.Value = DateTime.Now;
                    //}

                }
            }
            return true;
        }

        public static bool ControlValidation(Control control, ValidateType vt)
        {
            if (control.Visible && control.Enabled)
            {
                if (control is TextBox)
                {
                    TextBox txtbox = (TextBox)control;

                    if (!txtbox.ReadOnly && txtbox.Tag != null)
                    {
                        if (!String.IsNullOrEmpty(txtbox.Text))
                        {
                            switch (vt.ToString())

                            //switch (control.Tag.ToString())
                            {
                                case "Digit":
                                    {
                                        if (!IsNumeric(txtbox.Text))
                                        {
                                            txtbox.BackColor = Color.Khaki;
                                            //ChangeBorder(txtbox,Color.Red);
                                            return false;
                                        }
                                        txtbox.ResetBackColor();
                                    }
                                    break;
                                case "String":
                                    {
                                        if (txtbox.Text.Trim().Any(ch => !Char.IsLetterOrDigit(ch) && !Char.IsWhiteSpace(ch)))
                                        {
                                            txtbox.BackColor = Color.Khaki;
                                            return false;
                                        }
                                        txtbox.ResetBackColor();
                                    }
                                    break;
                                case "Date":
                                    ;
                                    break;
                                case "DateTime":
                                    ;
                                    break;
                                case "Email":
                                    ;
                                    break;
                                default:
                                    break;

                            }
                        }
                        else
                        {
                            txtbox.BackColor = Color.Khaki;
                            return false;
                        }
                    }


                }
                else if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count == 0 || String.IsNullOrEmpty(comboBox.Text))
                    {
                        comboBox.BackColor = Color.Khaki;
                        return false;
                    }
                    comboBox.ResetBackColor();
                }
            }

            return true;
        }

        public static bool ControlValidation(Control control, string vt)
        {
            if (control.Visible && control.Enabled)
            {
                if (control is TextBox)
                {
                    TextBox txtbox = (TextBox)control;

                    if (!txtbox.ReadOnly && txtbox.Tag != null)
                    {
                        if (!String.IsNullOrEmpty(txtbox.Text))
                        {
                            switch (vt.ToLower())

                            //switch (control.Tag.ToString())
                            {
                                case "digit":
                                    {
                                        if (!IsNumeric(txtbox.Text))
                                        {
                                            txtbox.BackColor = Color.Khaki;
                                            //ChangeBorder(txtbox,Color.Red);
                                            return false;
                                        }
                                        txtbox.ResetBackColor();
                                    }
                                    break;
                                case "string":
                                    {
                                        if (txtbox.Text.Trim().Any(ch => !Char.IsLetterOrDigit(ch) && !Char.IsWhiteSpace(ch)))
                                        {
                                            txtbox.BackColor = Color.Khaki;
                                            return false;
                                        }
                                        txtbox.ResetBackColor();
                                    }
                                    break;
                                case "date":
                                    ;
                                    break;
                                case "datetime":
                                    ;
                                    break;
                                case "email":
                                    ;
                                    break;
                                default:
                                    break;

                            }
                        }
                        else
                        {
                            txtbox.BackColor = Color.Khaki;
                            return false;
                        }
                    }


                }
                else if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count == 0 || String.IsNullOrEmpty(comboBox.Text))
                    {
                        comboBox.BackColor = Color.Khaki;
                        return false;
                    }
                    comboBox.ResetBackColor();
                }
            }

            return true;
        }

        public static bool ControlValidation(Control control)
        {
            if (control.Visible && control.Enabled)
            {
                if (control is TextBox)
                {
                    TextBox txtbox = (TextBox)control;

                    if (!txtbox.ReadOnly && txtbox.Tag != null)
                    {
                        if (!String.IsNullOrEmpty(txtbox.Text))
                        {
                            switch (control.Tag.ToString().ToLower())
                            {
                                case "digit":
                                    {
                                        if (!IsNumeric(txtbox.Text))
                                        {
                                            return false;
                                        }
                                    }
                                    break;
                                case "string":
                                    {
                                        if (txtbox.Text.Trim().Any(ch => !Char.IsLetterOrDigit(ch) && !Char.IsWhiteSpace(ch)))
                                        {
                                            return false;
                                        }
                                    }
                                    break;
                                case "date":
                                    ;
                                    break;
                                case "datetime":
                                    ;
                                    break;
                                case "email":
                                    ;
                                    break;
                                default:
                                    break;

                            }
                        }
                        else
                        {
                            return false;
                        }
                    }


                }
                else if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count == 0 || String.IsNullOrEmpty(comboBox.Text))
                    {
                        return false;
                    }
                }

            }

            return true;
        }

        public static bool ControlVDigit(string text)
        {
            if (String.IsNullOrEmpty(text) || !IsNumeric(text))
                return false;
            return true;
        }

        public static bool ControlVLetter(string text)
        {
            if (String.IsNullOrEmpty(text) || text.Trim().Any(ch => !Char.IsLetterOrDigit(ch) && !Char.IsWhiteSpace(ch)))
                return false;
            return true;
        }

        public static bool ControlVComboCheck(ComboBox comboBox)
        {
            if (comboBox.Items.Count == 0 || String.IsNullOrEmpty(comboBox.Text))
                return false;
            return true;
        }

        public static bool IsNumeric(object Expression)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(Expression), NumberStyles.Any, NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

    }
}
