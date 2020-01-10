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
    public partial class 注册 : Form
    {
        private Form1 superForm;
        public 注册(Form1 superForm)
        {
            InitializeComponent();
            this.superForm = superForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            superForm.Show();
            this.Close();
        }

        private void 注册_FormClosing(object sender, FormClosingEventArgs e)
        {
            superForm.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.ToString();
            string password = txtPassword.Text.ToString();
            int identity = radioStu.Checked ? 1 : 0;
            string name = txtName.Text.ToString();
            //根据用户输入的信息在数据库查询，如果能查到说明有该用户
            string userCmd = "insert into user (id, password, identity, name) values ('{0}','{1}','{2}','{3}')";
            userCmd = string.Format(userCmd, id, password, identity, name);
            if(MysqlUtil.operation(userCmd) != -1)
            {
                //注册成功
                DialogResult dr = MessageBox.Show("注册成功", "Tip", MessageBoxButtons.OK);
                if(dr == DialogResult.OK)
                {
                    superForm.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult res = MessageBox.Show("注册失败", "Tip", MessageBoxButtons.OK);
                }
            }
        }
    }
}
