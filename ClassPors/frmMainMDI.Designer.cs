
namespace ClassPors
{
    partial class frmMainMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.منویاصلیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResetFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.نظرسنجیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPoll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShowPoll = new System.Windows.Forms.ToolStripMenuItem();
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPollTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditBtn1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditBtn2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditBtn3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("B Titr", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.منویاصلیToolStripMenuItem,
            this.نظرسنجیToolStripMenuItem,
            this.ویرایشToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // منویاصلیToolStripMenuItem
            // 
            this.منویاصلیToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLoadFile,
            this.menuResetFile,
            this.menuExit});
            this.منویاصلیToolStripMenuItem.Name = "منویاصلیToolStripMenuItem";
            this.منویاصلیToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.منویاصلیToolStripMenuItem.Text = "منوی اصلی";
            // 
            // menuLoadFile
            // 
            this.menuLoadFile.Name = "menuLoadFile";
            this.menuLoadFile.Size = new System.Drawing.Size(191, 26);
            this.menuLoadFile.Text = "بارگیری فایل ذخیره شده";
            this.menuLoadFile.Click += new System.EventHandler(this.menuLoadFile_Click);
            // 
            // menuResetFile
            // 
            this.menuResetFile.Name = "menuResetFile";
            this.menuResetFile.Size = new System.Drawing.Size(191, 26);
            this.menuResetFile.Text = "پاک کردن فایل (نوسازی)";
            this.menuResetFile.Click += new System.EventHandler(this.menuResetFile_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(191, 26);
            this.menuExit.Text = "خروج";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // نظرسنجیToolStripMenuItem
            // 
            this.نظرسنجیToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPoll,
            this.menuShowPoll});
            this.نظرسنجیToolStripMenuItem.Name = "نظرسنجیToolStripMenuItem";
            this.نظرسنجیToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.نظرسنجیToolStripMenuItem.Text = "نظرسنجی";
            // 
            // menuPoll
            // 
            this.menuPoll.Name = "menuPoll";
            this.menuPoll.Size = new System.Drawing.Size(180, 26);
            this.menuPoll.Text = "اجرا";
            this.menuPoll.Click += new System.EventHandler(this.menuPoll_Click);
            // 
            // menuShowPoll
            // 
            this.menuShowPoll.Name = "menuShowPoll";
            this.menuShowPoll.Size = new System.Drawing.Size(180, 26);
            this.menuShowPoll.Text = "مشاهده آمار";
            this.menuShowPoll.Click += new System.EventHandler(this.menuShowPoll_Click);
            // 
            // ویرایشToolStripMenuItem
            // 
            this.ویرایشToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditPollTitle,
            this.menuEditBtn1,
            this.menuEditBtn2,
            this.menuEditBtn3});
            this.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            this.ویرایشToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.ویرایشToolStripMenuItem.Text = "ویرایش";
            // 
            // menuEditPollTitle
            // 
            this.menuEditPollTitle.Name = "menuEditPollTitle";
            this.menuEditPollTitle.Size = new System.Drawing.Size(190, 26);
            this.menuEditPollTitle.Text = "ویرایش موضوع نظرسنجی";
            this.menuEditPollTitle.Click += new System.EventHandler(this.menuEditPollTitle_Click);
            // 
            // menuEditBtn1
            // 
            this.menuEditBtn1.Name = "menuEditBtn1";
            this.menuEditBtn1.Size = new System.Drawing.Size(190, 26);
            this.menuEditBtn1.Text = "ویرایش عنوان کلید 1";
            this.menuEditBtn1.Click += new System.EventHandler(this.menuEditBtn1_Click);
            // 
            // menuEditBtn2
            // 
            this.menuEditBtn2.Name = "menuEditBtn2";
            this.menuEditBtn2.Size = new System.Drawing.Size(190, 26);
            this.menuEditBtn2.Text = "ویرایش عنوان کلید 2";
            this.menuEditBtn2.Click += new System.EventHandler(this.menuEditBtn2_Click);
            // 
            // menuEditBtn3
            // 
            this.menuEditBtn3.Name = "menuEditBtn3";
            this.menuEditBtn3.Size = new System.Drawing.Size(190, 26);
            this.menuEditBtn3.Text = "ویرایش عنوان کلید 3";
            this.menuEditBtn3.Click += new System.EventHandler(this.menuEditBtn3_Click);
            // 
            // frmMainMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMDI";
            this.Text = "frmMainMDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainMDI_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem منویاصلیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLoadFile;
        private System.Windows.Forms.ToolStripMenuItem menuResetFile;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem نظرسنجیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPoll;
        private System.Windows.Forms.ToolStripMenuItem menuShowPoll;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEditPollTitle;
        private System.Windows.Forms.ToolStripMenuItem menuEditBtn1;
        private System.Windows.Forms.ToolStripMenuItem menuEditBtn2;
        private System.Windows.Forms.ToolStripMenuItem menuEditBtn3;
    }
}