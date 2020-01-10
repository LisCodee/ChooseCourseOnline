namespace 在线选课系统
{
    partial class 老师查看选课
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
            this.gridTeacher = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.发布选课ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发布全校性选课ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeacher)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridTeacher
            // 
            this.gridTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTeacher.Location = new System.Drawing.Point(29, 83);
            this.gridTeacher.Name = "gridTeacher";
            this.gridTeacher.RowTemplate.Height = 23;
            this.gridTeacher.Size = new System.Drawing.Size(734, 341);
            this.gridTeacher.TabIndex = 31;
            this.gridTeacher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTeacher_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.发布选课ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 发布选课ToolStripMenuItem
            // 
            this.发布选课ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.发布全校性选课ToolStripMenuItem});
            this.发布选课ToolStripMenuItem.Name = "发布选课ToolStripMenuItem";
            this.发布选课ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.发布选课ToolStripMenuItem.Text = "发布选课";
            // 
            // 发布全校性选课ToolStripMenuItem
            // 
            this.发布全校性选课ToolStripMenuItem.Name = "发布全校性选课ToolStripMenuItem";
            this.发布全校性选课ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.发布全校性选课ToolStripMenuItem.Text = "发布全校性选课";
            this.发布全校性选课ToolStripMenuItem.Click += new System.EventHandler(this.发布全校性选课ToolStripMenuItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(674, 38);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 36);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "取消课程";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // 老师查看选课
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gridTeacher);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "老师查看选课";
            this.Text = "我的课程";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.老师查看选课_FormClosing);
            this.Load += new System.EventHandler(this.老师查看选课_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTeacher)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridTeacher;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 发布选课ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发布全校性选课ToolStripMenuItem;
        private System.Windows.Forms.Button btnCancel;
    }
}