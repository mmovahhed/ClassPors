namespace ClassPors
{
    partial class frmMain
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
            this.lblCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNorm = new ClassPors.Tables.RoundedButton();
            this.btnGood = new ClassPors.Tables.RoundedButton();
            this.btnBad = new ClassPors.Tables.RoundedButton();
            this.btnVBad = new ClassPors.Tables.RoundedButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = false;
            this.tableLayoutPanel1.SetColumnSpan(this.lblCaption, 4);
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaption.Font = new System.Drawing.Font("B Titr", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.TabIndex = 14;
            this.lblCaption.Text = "لطفا نظر خود را از بین گزینه های زیر انتخاب کنید";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblCaption, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGood, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNorm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBad, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnVBad, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCount, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(16);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 450);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("B Titr", 32F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.Blue;
            this.lblCount.Name = "lblCount";
            this.lblCount.TabIndex = 16;
            this.lblCount.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label1.Name = "label1";
            this.label1.TabIndex = 15;
            this.label1.Text = "تعداد کل";
            // 
            // btnGood
            // 
            this.btnGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(165)))), ((int)(((byte)(80)))));
            this.btnGood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGood.Font = new System.Drawing.Font("B Titr", 30F, System.Drawing.FontStyle.Bold);
            this.btnGood.ForeColor = System.Drawing.Color.White;
            this.btnGood.Margin = new System.Windows.Forms.Padding(8);
            this.btnGood.Name = "btnGood";
            this.btnGood.TabIndex = 1;
            this.btnGood.Text = "خوب";
            this.btnGood.UseVisualStyleBackColor = false;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // btnNorm
            // 
            this.btnNorm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnNorm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNorm.Font = new System.Drawing.Font("B Titr", 30F, System.Drawing.FontStyle.Bold);
            this.btnNorm.ForeColor = System.Drawing.Color.White;
            this.btnNorm.Margin = new System.Windows.Forms.Padding(8);
            this.btnNorm.Name = "btnNorm";
            this.btnNorm.TabIndex = 2;
            this.btnNorm.Text = "متوسط";
            this.btnNorm.UseVisualStyleBackColor = false;
            this.btnNorm.Click += new System.EventHandler(this.btnNorm_Click);
            // 
            // btnBad
            // 
            this.btnBad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(138)))), ((int)(((byte)(10)))));
            this.btnBad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBad.Font = new System.Drawing.Font("B Titr", 30F, System.Drawing.FontStyle.Bold);
            this.btnBad.ForeColor = System.Drawing.Color.White;
            this.btnBad.Margin = new System.Windows.Forms.Padding(8);
            this.btnBad.Name = "btnBad";
            this.btnBad.TabIndex = 3;
            this.btnBad.Text = "بد";
            this.btnBad.UseVisualStyleBackColor = false;
            this.btnBad.Click += new System.EventHandler(this.btnBad_Click);
            // 
            // btnVBad
            // 
            this.btnVBad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnVBad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVBad.Font = new System.Drawing.Font("B Titr", 30F, System.Drawing.FontStyle.Bold);
            this.btnVBad.ForeColor = System.Drawing.Color.White;
            this.btnVBad.Margin = new System.Windows.Forms.Padding(8);
            this.btnVBad.Name = "btnVBad";
            this.btnVBad.TabIndex = 17;
            this.btnVBad.Text = "خیلی بد";
            this.btnVBad.UseVisualStyleBackColor = false;
            this.btnVBad.Click += new System.EventHandler(this.btnVBad_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClassPors";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ClassPors.Tables.RoundedButton btnGood;
        private ClassPors.Tables.RoundedButton btnNorm;
        private ClassPors.Tables.RoundedButton btnBad;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCount;
        private Tables.RoundedButton btnVBad;
    }
}