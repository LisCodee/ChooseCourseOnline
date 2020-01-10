namespace 在线选课系统
{
    partial class 学生选课页面
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
            this.btnChoose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.网上选课ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全校性选课ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选课查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生选课情况查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridAllCourse = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChoose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChoose.Location = new System.Drawing.Point(299, 490);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(196, 35);
            this.btnChoose.TabIndex = 23;
            this.btnChoose.Text = "选课";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.网上选课ToolStripMenuItem,
            this.选课查询ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 网上选课ToolStripMenuItem
            // 
            this.网上选课ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全校性选课ToolStripMenuItem});
            this.网上选课ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.网上选课ToolStripMenuItem.Name = "网上选课ToolStripMenuItem";
            this.网上选课ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.网上选课ToolStripMenuItem.Text = "网上选课";
            // 
            // 全校性选课ToolStripMenuItem
            // 
            this.全校性选课ToolStripMenuItem.Name = "全校性选课ToolStripMenuItem";
            this.全校性选课ToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.全校性选课ToolStripMenuItem.Text = "全校性选课";
            // 
            // 选课查询ToolStripMenuItem
            // 
            this.选课查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生选课情况查询ToolStripMenuItem});
            this.选课查询ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.选课查询ToolStripMenuItem.Name = "选课查询ToolStripMenuItem";
            this.选课查询ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.选课查询ToolStripMenuItem.Text = "选课查询";
            // 
            // 学生选课情况查询ToolStripMenuItem
            // 
            this.学生选课情况查询ToolStripMenuItem.Name = "学生选课情况查询ToolStripMenuItem";
            this.学生选课情况查询ToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.学生选课情况查询ToolStripMenuItem.Text = "学生选课情况查询";
            this.学生选课情况查询ToolStripMenuItem.Click += new System.EventHandler(this.学生选课情况查询ToolStripMenuItem_Click);
            // 
            // gridAllCourse
            // 
            this.gridAllCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAllCourse.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridAllCourse.Location = new System.Drawing.Point(27, 57);
            this.gridAllCourse.Name = "gridAllCourse";
            this.gridAllCourse.RowTemplate.Height = 23;
            this.gridAllCourse.Size = new System.Drawing.Size(748, 404);
            this.gridAllCourse.TabIndex = 25;
            // 
            // 学生选课页面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.gridAllCourse);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "学生选课页面";
            this.Text = "学生选课页面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.学生选课页面_FormClosing);
            this.Load += new System.EventHandler(this.学生选课页面_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 网上选课ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全校性选课ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选课查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生选课情况查询ToolStripMenuItem;
        private System.Windows.Forms.DataGridView gridAllCourse;
    }
}