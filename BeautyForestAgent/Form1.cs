using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeautyForestAgent
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void VisibleChange(bool visible)
        {
            this.Visible = visible;
            this.ntiTray.Visible = !visible;
        }

        private void 폼보이기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleChange(true);
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ntiTray.Visible = false;
            Application.ExitThread();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            VisibleChange(false);
        }

        private void BtnTray_Click(object sender, EventArgs e)
        {
            VisibleChange(false);
        }

        private void NtiTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.statusMessage.Text = "종료합니다.";
            VisibleChange(true);
        }

        private void 수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusMessage.Text = "수정 창을 띄웁니다.";
            showModify();
        }

        private static void showModify()
        {
            FormModify m = new FormModify();
            m.Title = "수정 창띄우기";
            m.ShowDialog();
        }

        private void 끝내기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();  // 어플리케이션 쓰레드 완전 종료
        }


        private void 추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusMessage.Text = "추가 창을 띄웁니다.";
            showAdd();

        }

        private static void showAdd()
        {
            FormAdd m = new FormAdd();
            m.Title = "추가 창띄우기";
            m.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.statusMessage.Text = "추가 창을 띄웁니다.";
            showAdd();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            this.statusMessage.Text = "수정 창을 띄웁니다.";
            showModify();
        }

        private void 이프로그램은ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusMessage.Text = "이 프로그램은..(Modal) 창을 띄웁니다.";
            FormAbout m = new FormAbout();
            m.Title = "이 프로그램은..(Modal) 창 띄우기";
            m.ShowDialog();
        }
    }

}
