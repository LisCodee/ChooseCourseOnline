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
    public partial class 选课查询 : Form
    {
        private string stu_id;
        private 学生选课页面 superForm;
        public 选课查询(string id, 学生选课页面 superForm)
        {
            InitializeComponent();
            this.stu_id = id;
            this.superForm = superForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 选课查询_Load(object sender, EventArgs e)
        {
            FillCourse();
        }

        public void FillCourse()
        {
            gridMyCourse.ColumnCount = 8;
            gridMyCourse.Columns[0].Name = "课程id";
            gridMyCourse.Columns[1].Name = "课程名称";
            gridMyCourse.Columns[2].Name = "教师";
            gridMyCourse.Columns[3].Name = "上课时间";
            gridMyCourse.Columns[4].Name = "上课地点";
            gridMyCourse.Columns[5].Name = "学分";
            gridMyCourse.Columns[6].Name = "余量";
            gridMyCourse.Columns[7].Name = "id";
            gridMyCourse.ReadOnly = true;
            //不允许添加行
            gridMyCourse.AllowUserToAddRows = false;
            //背景为白色
            gridMyCourse.BackgroundColor = Color.White;
            //只允许选中单行
            gridMyCourse.MultiSelect = false;
            //整行选中
            gridMyCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                string sqlcmd = "select id,course_id from stu_course where stu_id=" + stu_id + " and effective=0";
                MySqlConnection conn = MysqlUtil.createConn();
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlcmd, conn);
                DataSet set = new DataSet("stu_course");
                adapter.Fill(set);
                conn.Close();
                string name, tearcher_name, time, place, score, remain_peo;
                foreach(DataRow row in set.Tables[0].Rows)
                {
                    string id = row["id"].ToString();
                    string course_id = row["course_id"].ToString();
                    string search_course = "select name,teacher_name,time,place,score,remain_peo from course where id=" + course_id + " and effective=0";
                    Console.WriteLine(search_course);
                    MySqlDataReader dr = MysqlUtil.search(search_course);
                    if (!dr.Read())
                    {
                        continue;
                    }
                    else
                    {
                        name = dr[0].ToString();
                        tearcher_name = dr[1].ToString();
                        time = dr[2].ToString();
                        place = dr[3].ToString();
                        score = dr[4].ToString();
                        remain_peo = dr[5].ToString();
                    }
                    string[] item = { course_id, name, tearcher_name, tearcher_name, place, score, remain_peo, id };
                    gridMyCourse.Rows.Add(item);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("数据加载失败", "ERROR", MessageBoxButtons.OK);
                this.Close();
            }
        }
        //取消选课
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                string id = gridMyCourse.SelectedRows[0].Cells[7].Value.ToString();
                string update_user_course = "update stu_course set effective=1 where id='{0}'";
                update_user_course = string.Format(update_user_course,id);
                Console.WriteLine(update_user_course);
                if (MysqlUtil.operation(update_user_course) != -1)
                {
                    MessageBox.Show("取消选课成功", "Tip", MessageBoxButtons.OK);
                    this.FillCourse();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("你没有选中课程", "Tip", MessageBoxButtons.OK);
            }
        }
    }
}
