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
            this.btnGrid = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGood = new System.Windows.Forms.Button();
            this.btnNorm = new System.Windows.Forms.Button();
            this.btnBad = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.lblCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGrid
            // 
            this.btnGrid.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGrid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGrid.Location = new System.Drawing.Point(316, 205);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(160, 35);
            this.btnGrid.TabIndex = 4;
            this.btnGrid.Text = "نمایش آمار";
            this.btnGrid.UseVisualStyleBackColor = true;
            this.btnGrid.Click += new System.EventHandler(this.btnGrid_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReset.Location = new System.Drawing.Point(401, 246);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(160, 35);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "پاک کردن فایل";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExit.Location = new System.Drawing.Point(316, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGood
            // 
            this.btnGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGood.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGood.ForeColor = System.Drawing.Color.Green;
            this.btnGood.Location = new System.Drawing.Point(45, 106);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(160, 68);
            this.btnGood.TabIndex = 1;
            this.btnGood.Text = "خوب";
            this.btnGood.UseVisualStyleBackColor = false;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // btnNorm
            // 
            this.btnNorm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNorm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNorm.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNorm.ForeColor = System.Drawing.Color.Blue;
            this.btnNorm.Location = new System.Drawing.Point(316, 106);
            this.btnNorm.Name = "btnNorm";
            this.btnNorm.Size = new System.Drawing.Size(160, 68);
            this.btnNorm.TabIndex = 2;
            this.btnNorm.Text = "متوسط";
            this.btnNorm.UseVisualStyleBackColor = false;
            this.btnNorm.Click += new System.EventHandler(this.btnNorm_Click);
            // 
            // btnBad
            // 
            this.btnBad.BackColor = System.Drawing.Color.Silver;
            this.btnBad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBad.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBad.ForeColor = System.Drawing.Color.Black;
            this.btnBad.Location = new System.Drawing.Point(585, 106);
            this.btnBad.Name = "btnBad";
            this.btnBad.Size = new System.Drawing.Size(160, 68);
            this.btnBad.TabIndex = 3;
            this.btnBad.Text = "بد";
            this.btnBad.UseVisualStyleBackColor = false;
            this.btnBad.Click += new System.EventHandler(this.btnBad_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLoadFile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnLoadFile.Location = new System.Drawing.Point(235, 246);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(160, 35);
            this.btnLoadFile.TabIndex = 5;
            this.btnLoadFile.Text = "بارگیری فایل ذخیره شده";
            this.btnLoadFile.UseVisualStyleBackColor = false;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCaption.ForeColor = System.Drawing.Color.Red;
            this.lblCaption.Location = new System.Drawing.Point(85, 30);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(618, 33);
            this.lblCaption.TabIndex = 14;
            this.lblCaption.Text = "لطفا نظر خود را از بین گزینه های زیر انتخاب کنید";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 351);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnBad);
            this.Controls.Add(this.btnNorm);
            this.Controls.Add(this.btnGood);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGrid);
            this.Controls.Add(this.btnReset);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassPors";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrid;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.Button btnNorm;
        private System.Windows.Forms.Button btnBad;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Label lblCaption;
    }
}