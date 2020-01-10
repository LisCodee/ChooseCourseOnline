using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace 在线选课系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtName.Text.ToString();
            string password = txtPassword.Text.ToString();
            int identity = radioStu.Checked ? 1 : 0;
            //根据用户输入的信息在数据库查询，如果能查到说明有该用户
            string userCmd = "select * from user where id='{0}' and password='{1}' and identity='{2}'";
            userCmd = string.Format(userCmd, id, password, identity);
            MySqlDataReader user = MysqlUtil.search(userCmd);
            if (user.Read())
            {
                if(identity == 1)
                {
                    var frm = new 学生选课页面(this, id);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    var frm = new 老师查看选课(this,id,user[3].ToString());
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重新输入!", "Tip", MessageBoxButtons.OK);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            var registerForm = new 注册(this);
            registerForm.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定退出？", "Tip", MessageBoxButtons.OKCancel);
            if(dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
