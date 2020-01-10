namespace 在线选课系统
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.labRegister = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.radioStu = new System.Windows.Forms.RadioButton();
            this.radioTeacher = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(320, 194);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 21);
            this.txtName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(275, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(203, 47);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(408, 94);
            this.pictureLogo.TabIndex = 5;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labRegister
            // 
            this.labRegister.AutoSize = true;
            this.labRegister.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRegister.Location = new System.Drawing.Point(454, 369);
            this.labRegister.Name = "labRegister";
            this.labRegister.Size = new System.Drawing.Size(55, 10);
            this.labRegister.TabIndex = 6;
            this.labRegister.Text = "没有账号？";
            this.labRegister.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "账号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "密码：";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(320, 235);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(189, 21);
            this.txtPassword.TabIndex = 8;
            // 
            // radioStu
            // 
            this.radioStu.AutoSize = true;
            this.radioStu.Location = new System.Drawing.Point(320, 284);
            this.radioStu.Name = "radioStu";
            this.radioStu.Size = new System.Drawing.Size(47, 16);
            this.radioStu.TabIndex = 10;
            this.radioStu.TabStop = true;
            this.radioStu.Text = "学生";
            this.radioStu.UseVisualStyleBackColor = true;
            // 
            // radioTeacher
            // 
            this.radioTeacher.AutoSize = true;
            this.radioTeacher.Location = new System.Drawing.Point(461, 284);
            this.radioTeacher.Name = "radioTeacher";
            this.radioTeacher.Size = new System.Drawing.Size(47, 16);
            this.radioTeacher.TabIndex = 11;
            this.radioTeacher.TabStop = true;
            this.radioTeacher.Text = "老师";
            this.radioTeacher.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioTeacher);
            this.Controls.Add(this.radioStu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labRegister);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label labRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton radioStu;
        private System.Windows.Forms.RadioButton radioTeacher;
    }
}

