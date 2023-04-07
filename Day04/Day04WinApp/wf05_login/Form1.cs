using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf05_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class data
        {
            public string[] id = new string[] { "abcd", "qwer" };
            public string[] pw = new string[] { "1234", "7890" };
        }
        private void Btn_login_Click(object sender, EventArgs e)
        {

            data myData = new data();
            if (Tb_Id.Text == ""){
                La_msg.Text = "아이디를 입력하세요";
            }
            else if(Tb_Pw.Text == ""){ 
                La_msg.Text = "비번을 입력하세요";
            }
            else if (myData.id.Contains(Tb_Id.Text) && myData.pw.Contains(Tb_Pw.Text)) { 
                La_msg.Text = "로그인 성공";
            }
            else {
                La_msg.Text = "아이디 또는 비번 오류";
            }
        }
    }
}
