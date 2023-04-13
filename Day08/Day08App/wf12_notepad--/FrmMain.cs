using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf12_notepad__
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {   // 파일 불러오기, 스트림 리더를 사용
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;                     // 여러파일 선택안되도록
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                TxtPath.Text = fileName;

                FileStream stream = null;
                StreamReader reader = null;

                // 파일을 불러왔을 때
                try
                {
                    stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    reader = new StreamReader(stream, Encoding.UTF8);

                    // 전부 다 읽어오기
                    RtbEditor.Text = reader.ReadToEnd();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"오류! {ex.Message}", "심플 메모장", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    reader.Close();
                    stream.Close();
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {   // 파일 쓰기, 스트림 라이터 사용
            string fileName = TxtPath.Text;

            FileStream stream = null;
            StreamWriter writer = null;
            try
            {
                stream = new FileStream(fileName, FileMode.Truncate, FileAccess.Write);
                writer = new StreamWriter(stream, Encoding.UTF8);
                
                writer.WriteLine(RtbEditor.Text);   // 리치텍스트 박스 내용을 씀
                writer.Flush();                     // 버퍼의 데이터를 해당 스트림에 전송

                MessageBox.Show("저장되었습니다.", "심플 메모장", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류! {ex.Message}", "심플 메모장", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { 
                writer.Close();
                stream.Close();
            }
        }
    }
}
