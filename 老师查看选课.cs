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
    public partial class 老师查看选课 : Form
    {
        private string id;
        private string name;
        private Form1 superForm;
        public 老师查看选课(Form1 superForm, string id, string name)
        {
            InitializeComponent();
            this.superForm = superForm;
            this.id = id;
            this.name = name;
        }

        private void 老师查看选课_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定退出应用么？", "Tip", MessageBoxButtons.OKCancel);
            //Console.WriteLine(dr);
            if (dr == DialogResult.OK)
            {
                Console.WriteLine(superForm.Text);
                superForm.Close();
            }
            else
                e.Cancel = true;
            Console.WriteLine("取消");
        }

        private void 发布全校性选课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pubCourse = new 发布课程(id, name, this);
            pubCourse.Show();
        }

        private void gridTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 老师查看选课_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        
        public void Reload()
        {
            FillGrid();
        }
        private void FillGrid()
        {
            try
            {
                MySqlConnection conn = MysqlUtil.createConn();
                string data = "select id,name,time,place,score,remain_peo from course where teacher_id=" + id + " and effective=0";
                conn.Open();
                DataSet set = new DataSet();
                MySqlDataAdapter adapter = new MySqlDataAdapter(data, conn);
                adapter.Fill(set);
                gridTeacher.DataSource = set.Tables[0];
                //设置表头
                gridTeacher.Columns[1].HeaderText = "名字";
                gridTeacher.Columns[2].HeaderText = "上课时间";
                gridTeacher.Columns[3].HeaderText = "上课地点";
                gridTeacher.Columns[4].HeaderText = "课程学分";
                gridTeacher.Columns[5].HeaderText = "课程余量";
                gridTeacher.Columns[0].HeaderText = "id";
                gridTeacher.ReadOnly = true;
                //不允许添加行
                gridTeacher.AllowUserToAddRows = false;
                //背景为白色
                gridTeacher.BackgroundColor = Color.White;
                //只允许选中单行
                gridTeacher.MultiSelect = false;
                //整行选中
                gridTeacher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }catch(Exception e)
            {
                MessageBox.Show("数据加载失败", "ERROR", MessageBoxButtons.OK);
                this.Close();
            }
        }
        //取消课程
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                string course_id = gridTeacher.SelectedRows[0].Cells[0].Value.ToString();
                string cancel_course = "update course set effective=1 where id=" + course_id;
                if (MysqlUtil.operation(cancel_course) != -1)
                {
                    MessageBox.Show("取消课程成功", "Tip", MessageBoxButtons.OK);
                    this.FillGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("取消课程失败", "Tip", MessageBoxButtons.OK);
            }
        }
    }
}
