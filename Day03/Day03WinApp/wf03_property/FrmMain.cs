using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf03_property
{
    public partial class FrmMain : Form
    {

        Random rnd = new Random(45);
        public FrmMain()    // 생성자, 가급적 여기에는 뭘 넣지 말 것
        {
            InitializeComponent();
            //GbxMain.Text = "그룹박스";  // 우선 이니셜라이즈가 되고 나서 이걸 작성해야한다.
            // 생성자에는 되도록 설정부분을 넣지 말 것
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GbxMain.Text = "컨트롤 학습";
            var fonts = FontFamily.Families.ToList();       // 내 OS 폰트이름 가져오기
            foreach (var font in fonts)
            {
                CboFontFamily.Items.Add(font.Name);
            }

            // 글자크기 최소값, 최대값 지정
            NudFontSize.Minimum = 5;
            NudFontSize.Maximum = 40;
            // 텍스트박스 초기화
            TxtResult.Text = "Hello World!";

            NudFontSize.Value = 9;      // 최초 글자 크기 값

        }
        /// <summary>
        /// 글자 스타일, 크기, 글자체를 변경해주는 메서드
        /// </summary>
        private void ChangeFontStyle()
        {
            if (CboFontFamily.SelectedIndex < 0) return;

            FontStyle style = FontStyle.Regular;    // 기본
            if (ChkBold.Checked) style |= FontStyle.Bold; // 비트연산 or
            if (ChkItalic.Checked) style |= FontStyle.Italic;

            decimal fontSize = NudFontSize.Value;

            TxtResult.Font = new Font((string)CboFontFamily.SelectedItem, (float)fontSize, style);


        }
        void ChangeIndent()
        {
            if (RdoNormal.Checked)  // 라디오 버튼
            {
                TxtResult.Text = TxtResult.Text.Trim();
            }
            else if (RdoIndent.Checked)
            {
                TxtResult.Text = "   " + TxtResult.Text;

            }
        }

        private void CboFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();

        }

        private void NudFontSize_ValueChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void TrbDummy_Scroll(object sender, EventArgs e)
        {
            PgbDummy.Value = TrbDummy.Value;
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form()
            {
                Text = "Modal Form",
                Width = 300,
                Height = 200,
                Left = 10,
                Top = 20,
                BackColor = Color.AliceBlue,
            };
            frm.ShowDialog(); // 모달 방식으로 자식 창 띄우기
            // 모달창이 켜져 있으면 부모창을 선택할 수 없다.
        

        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form()
            {
                Text = "ModalessForm",
                Width = 300,
                Height = 200,
                StartPosition = FormStartPosition.CenterParent,
                BackColor = Color.GreenYellow

            };
            frm.Show();     // 모달리스 방식으로 자식창 띄움
            // 모달리스는 자신이 띄워져 있는 상태에서 부모창을 선택할 수 있음
        }

        // 기본적으로 메시지 박스는 모달이다.
        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(TxtResult.Text);        // 기본
            //MessageBox.Show(TxtResult.Text, caption: "메시지창", MessageBoxButtons.AbortRetryIgnore);     // 버튼 추가
            //MessageBox.Show(TxtResult.Text, caption: "메시지창", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);       // 창에 아이콘 추가
/*            MessageBox.Show(TxtResult.Text, caption: "메시지창", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button2);       // 기본 포커스 버튼 설정*/
/*            MessageBox.Show(TxtResult.Text, caption: "메시지창", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);       // 기본 포커스 버튼 설정*/
            MessageBox.Show(TxtResult.Text, "메시지창", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 
                MessageBoxDefaultButton.Button2,MessageBoxOptions.RightAlign); // 오른쪽 정렬       // 기본 포커스 버튼 설정
        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            TrvDummy.Nodes.Add(rnd.Next(50).ToString());
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            if(TrvDummy.SelectedNode != null)
            {
                TrvDummy.SelectedNode.Nodes.Add(rnd.Next(50, 100).ToString());
                TrvDummy.SelectedNode.Expand();     // 트리노드 하위것 펼쳐주기, 반대는 .Collapse
                TreeToList();
            }
        }

        void TreeToList()
        {
            LsvDummy.Items.Clear();     // 리스트뷰, 트리뷰 모든 아이템을 제거 초기화 메서드
            foreach(TreeNode item in TrvDummy.Nodes)
            {
                TreeToList(item);
            }

        }

        private void TreeToList(TreeNode item)
        {
            LsvDummy.Items.Add(
                new ListViewItem(new []{ item.Text, item.FullPath.ToString() }));
            foreach (TreeNode node in item.Nodes)
            {
                TreeToList(node);//재귀 호출
            }
        }

        private void RdoNormal_CheckedChanged(object sender, EventArgs e)
        {
            ChangeIndent();
        }

        private void RdoIndent_CheckedChanged(object sender, EventArgs e)
        {
            ChangeIndent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            PcbDummy.Image = Bitmap.FromFile("cat.jpg");
        }

        private void PcbDummy_Click(object sender, EventArgs e)
        {
            if (PcbDummy.SizeMode == PictureBoxSizeMode.Normal)
            {
                PcbDummy.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                PcbDummy.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
