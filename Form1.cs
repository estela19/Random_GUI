using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace IceWall_Random
{
    public partial class Form1 : Form
    {

        public static ArrayList ContentList = new ArrayList (new string[]{ "과자", "술", "화장품", "라면", "항공사", "전자기기 회사", "치킨", "피자", "은행", "베스킨라빈스", "한양대건물", "명품브랜드" });

        public Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        public void choice()
        {
            int idx = rand.Next(0, ContentList.Count);
            string tmp = ContentList[idx].ToString();
            ContentList.RemoveAt(idx);
            MessageBox.Show(tmp, "두-둥!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            choice();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            choice();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            choice();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            choice();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            choice();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            choice();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            choice();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            choice();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            choice();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            choice();
        }

    }
}
