﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf13_bookrentalshop
{
    public partial class FrmMain : Form
    {
        #region< 생성자 >
        public FrmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region< 이벤트 핸들러 영역>

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MniGenre_Click(object sender, EventArgs e)
        {

        }

        private void MniBookInfo_Click(object sender, EventArgs e)
        {

        }

        private void MniMember_Click(object sender, EventArgs e)
        {

        }

        private void MniRental_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
