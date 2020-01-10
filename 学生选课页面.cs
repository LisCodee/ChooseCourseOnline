using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace 在线选课系统
{
    public partial class 学生选课页面 : Form
    {
        private Form1 superForm;
        private string id;
        public 学生选课页面(Form1 superForm, string id)
        {
            InitializeComponent();
            this.superForm = superForm;
            this.id = id;
        }

       

        private void 学生选课页面_Load(object sender, EventArgs e)
        {
            FillCourse();
        }
        public void FillCourse()
        {
            try
            {
                string sqlcmd = "select id,name,teacher_name,time,place,score,remain_peo from course where effective=0";
                MySqlConnection conn = MysqlUtil.createConn();
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlcmd, conn);
                DataSet set = new DataSet();
                adapter.Fill(set);
                gridAllCourse.DataSource = set.Tables[0];
                //设置表头
                gridAllCourse.Columns[0].HeaderText = "课程id";
                gridAllCourse.Columns[1].HeaderText = "课程名称";
                gridAllCourse.Columns[2].HeaderText = "教师";
                gridAllCourse.Columns[3].HeaderText = "上课时间";
                gridAllCourse.Columns[4].HeaderText = "上课地点";
                gridAllCourse.Columns[5].HeaderText = "学分";
                gridAllCourse.Columns[6].HeaderText = "余量";
                gridAllCourse.ReadOnly = true;
                //不允许添加行
                gridAllCourse.AllowUserToAddRows = false;
                //背景为白色
                gridAllCourse.BackgroundColor = Color.White;
                //只允许选中单行
                gridAllCourse.MultiSelect = false;
                //整行选中
                gridAllCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception e)
            {
                MessageBox.Show("数据加载失败", "ERROR", MessageBoxButtons.OK);
                this.Close();
            }
        }
        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void 学生选课页面_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定退出应用么？", "Tip", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                Console.WriteLine(superForm.Text);
                superForm.Close();
            }
            else
                e.Cancel = true;
            Console.WriteLine("取消");
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            try
            {
                string course_id = gridAllCourse.SelectedRows[0].Cells[0].Value.ToString();
                int remain = int.Parse(gridAllCourse.SelectedRows[0].Cells[6].Value.ToString());
                string stu_id = id;
                if(remain <= 0)
                {
                    MessageBox.Show("课程已无余量", "Tip", MessageBoxButtons.OK);
                    return;
                }
                string search_user = "select * from stu_course where course_id='{0}' and stu_id='{1}' and effective=0";
                search_user = string.Format(search_user, course_id, stu_id);
                MySqlDataReader reader = MysqlUtil.search(search_user);
                if (reader.Read())
                {
                    DialogResult dr = MessageBox.Show("你已经选过此课程，不允许重复选课", "Tip", MessageBoxButtons.OK);
                    return;
                }
                string update_course = "update course set remain_peo=remain_peo-1 where id=" + course_id;
                string update_stu_course = "insert into stu_course (course_id,stu_id) values ('{0}','{1}')";
                update_stu_course = string.Format(update_stu_course, course_id, stu_id);
                if(MysqlUtil.operation(update_course) != -1 && MysqlUtil.operation(update_stu_course) != -1)
                {
                    MessageBox.Show("选课成功", "Tip", MessageBoxButtons.OK);
                    this.FillCourse();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("你没有选中课程", "Tip", MessageBoxButtons.OK);
            }


        }

        private void 学生选课情况查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new 选课查询(id, this);
            frm.Show();
        }
    }
}
