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
            this.btnNorm = new ClassPors.Tables.RoundedButton();
            this.btnGood = new ClassPors.Tables.RoundedButton();
            this.btnBad = new ClassPors.Tables.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCaption.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblCaption, 3);
            this.lblCaption.Font = new System.Drawing.Font("B Titr", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCaption.ForeColor = System.Drawing.Color.Red;
            this.lblCaption.Location = new System.Drawing.Point(149, 112);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(492, 47);
            this.lblCaption.TabIndex = 14;
            this.lblCaption.Text = "لطفا نظر خود را از بین گزینه های زیر انتخاب کنید";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.lblCount, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNorm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnGood, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnBad, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCaption, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 450);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // btnNorm
            // 
            this.btnNorm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNorm.BackColor = System.Drawing.Color.Blue;
            this.btnNorm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNorm.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold);
            this.btnNorm.ForeColor = System.Drawing.Color.White;
            this.btnNorm.Location = new System.Drawing.Point(316, 227);
            this.btnNorm.Name = "btnNorm";
            this.btnNorm.Size = new System.Drawing.Size(160, 68);
            this.btnNorm.TabIndex = 2;
            this.btnNorm.Text = "متوسط";
            this.btnNorm.UseVisualStyleBackColor = false;
            this.btnNorm.Click += new System.EventHandler(this.btnNorm_Click);
            // 
            // btnGood
            // 
            this.btnGood.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGood.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGood.ForeColor = System.Drawing.Color.White;
            this.btnGood.Location = new System.Drawing.Point(578, 227);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(160, 68);
            this.btnGood.TabIndex = 1;
            this.btnGood.Text = "خوب";
            this.btnGood.UseVisualStyleBackColor = false;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // btnBad
            // 
            this.btnBad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBad.BackColor = System.Drawing.Color.Red;
            this.btnBad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBad.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold);
            this.btnBad.ForeColor = System.Drawing.Color.White;
            this.btnBad.Location = new System.Drawing.Point(52, 227);
            this.btnBad.Name = "btnBad";
            this.btnBad.Size = new System.Drawing.Size(160, 68);
            this.btnBad.TabIndex = 3;
            this.btnBad.Text = "بد";
            this.btnBad.UseVisualStyleBackColor = false;
            this.btnBad.Click += new System.EventHandler(this.btnBad_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(595, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 56);
            this.label1.TabIndex = 15;
            this.label1.Text = "تعداد کل";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("B Titr", 24F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.Blue;
            this.lblCount.Location = new System.Drawing.Point(486, 336);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(38, 56);
            this.lblCount.TabIndex = 16;
            this.lblCount.Text = "0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
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
    }
}