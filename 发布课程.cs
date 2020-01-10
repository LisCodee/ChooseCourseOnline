using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 在线选课系统
{
    public partial class 发布课程 : Form
    {
        private string id;
        private string name;
        private 老师查看选课 superForm;
        public 发布课程(string id, string name, 老师查看选课 superForm)
        {
            InitializeComponent();
            this.superForm = superForm;
            this.id = id;
            this.name = name;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("确定添加课程？", "Tip", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                string course_name = txtCourseName.Text.ToString();
                string teacher_id = this.id;
                string teacher_name = this.name;
                string time = txtCourseTime.Text.ToString();
                string place = txtCoursePlace.Text.ToString();
                string score = txtCourseScore.Text.ToString();
                string remain = txtCourseReamin.Text.ToString();
                string insertCourse = "insert into course (name, teacher_id, teacher_name, time, place, score, remain_peo) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
                insertCourse = string.Format(insertCourse,course_name, teacher_id, teacher_name, time, place, score, remain);
                Console.WriteLine(insertCourse);
                if(MysqlUtil.operation(insertCourse) != -1)
                {
                    MessageBox.Show("添加课程成功", "Tip", MessageBoxButtons.OK);
                    superForm.Reload();
                    this.Close();
                }
                else
                {
                    DialogResult d = MessageBox.Show("添加课程失败，请重试", "error", MessageBoxButtons.OK);
                }
            }
        }
    }
}
