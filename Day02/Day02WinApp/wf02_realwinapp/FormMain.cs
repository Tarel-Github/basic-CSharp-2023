using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf02_realwinapp
{
    public partial class FormMain : Form    // partial은 이름이 같은 여러 클래스를 별개로 동작하게 해줌
    {
        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 버튼 OK 클릭 이벤트에 대한 처리메서드를 만듦
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼클릭", "클릭", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            BtnOK.Text = "응애";
        }

        private void BtnOK_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("이벤트 발생!!");
        }
    }
}
