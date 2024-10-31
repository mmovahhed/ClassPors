using ClassPors.Tables;
using System;
using System.Windows.Forms;

namespace ClassPors
{
    public partial class frmGrid : Form
    {
        public frmGrid()
        {
            InitializeComponent();
        }

        private void frmGrid_Load(object sender, EventArgs e)
        {
            fillChart();
            lblCount.Text = CPors.Total.ToString();
        }

        void fillChart()
        {
            try
            {
                chart1.Series.Clear();
                chart1.Series.Add("Series1");
                chart1.Series["Series1"].Points.AddXY("خوب", CPors.Good);
                chart1.Series["Series1"].Points.AddXY("متوسط", CPors.Norm);
                chart1.Series["Series1"].Points.AddXY("بد", CPors.Bad);
                //chart title  
                chart1.Titles.Add("آمار تفکیکی");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
