namespace wf05_login
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.La_Id = new System.Windows.Forms.Label();
            this.La_Pw = new System.Windows.Forms.Label();
            this.La_msg = new System.Windows.Forms.Label();
            this.Tb_Id = new System.Windows.Forms.TextBox();
            this.Tb_Pw = new System.Windows.Forms.TextBox();
            this.Btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // La_Id
            // 
            this.La_Id.AutoSize = true;
            this.La_Id.Location = new System.Drawing.Point(40, 57);
            this.La_Id.Name = "La_Id";
            this.La_Id.Size = new System.Drawing.Size(41, 12);
            this.La_Id.TabIndex = 0;
            this.La_Id.Text = "아이디";
            // 
            // La_Pw
            // 
            this.La_Pw.AutoSize = true;
            this.La_Pw.Location = new System.Drawing.Point(40, 90);
            this.La_Pw.Name = "La_Pw";
            this.La_Pw.Size = new System.Drawing.Size(53, 12);
            this.La_Pw.TabIndex = 1;
            this.La_Pw.Text = "패스워드";
            // 
            // La_msg
            // 
            this.La_msg.AutoSize = true;
            this.La_msg.Location = new System.Drawing.Point(67, 184);
            this.La_msg.Name = "La_msg";
            this.La_msg.Size = new System.Drawing.Size(93, 12);
            this.La_msg.TabIndex = 2;
            this.La_msg.Text = "로그인 해주세요";
            // 
            // Tb_Id
            // 
            this.Tb_Id.Location = new System.Drawing.Point(99, 54);
            this.Tb_Id.Name = "Tb_Id";
            this.Tb_Id.Size = new System.Drawing.Size(100, 21);
            this.Tb_Id.TabIndex = 3;
            // 
            // Tb_Pw
            // 
            this.Tb_Pw.Location = new System.Drawing.Point(99, 87);
            this.Tb_Pw.Name = "Tb_Pw";
            this.Tb_Pw.Size = new System.Drawing.Size(100, 21);
            this.Tb_Pw.TabIndex = 4;
            // 
            // Btn_login
            // 
            this.Btn_login.Location = new System.Drawing.Point(151, 135);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(75, 23);
            this.Btn_login.TabIndex = 5;
            this.Btn_login.Text = "로그인";
            this.Btn_login.UseVisualStyleBackColor = true;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 230);
            this.Controls.Add(this.Btn_login);
            this.Controls.Add(this.Tb_Pw);
            this.Controls.Add(this.Tb_Id);
            this.Controls.Add(this.La_msg);
            this.Controls.Add(this.La_Pw);
            this.Controls.Add(this.La_Id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label La_Id;
        private System.Windows.Forms.Label La_Pw;
        private System.Windows.Forms.Label La_msg;
        private System.Windows.Forms.TextBox Tb_Id;
        private System.Windows.Forms.TextBox Tb_Pw;
        private System.Windows.Forms.Button Btn_login;
    }
}

