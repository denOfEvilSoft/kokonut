
namespace kokonutTalk
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
            this.components = new System.ComponentModel.Container();
            this.b_logIn = new System.Windows.Forms.Button();
            this.b_logOut = new System.Windows.Forms.Button();
            this.t_idBox = new System.Windows.Forms.TextBox();
            this.t_passwardBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_find_password = new System.Windows.Forms.Button();
            this.b_find_id = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_register = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.t_input_text = new System.Windows.Forms.TextBox();
            this.b_send = new System.Windows.Forms.Button();
            this.b_join = new System.Windows.Forms.Button();
            this.l_users = new System.Windows.Forms.ListBox();
            this.l_public = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.get_while_timer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_logIn
            // 
            this.b_logIn.Location = new System.Drawing.Point(119, 20);
            this.b_logIn.Name = "b_logIn";
            this.b_logIn.Size = new System.Drawing.Size(75, 23);
            this.b_logIn.TabIndex = 0;
            this.b_logIn.Text = "로그인";
            this.b_logIn.UseVisualStyleBackColor = true;
            this.b_logIn.Click += new System.EventHandler(this.b_logIn_Click);
            // 
            // b_logOut
            // 
            this.b_logOut.Enabled = false;
            this.b_logOut.Location = new System.Drawing.Point(119, 49);
            this.b_logOut.Name = "b_logOut";
            this.b_logOut.Size = new System.Drawing.Size(75, 23);
            this.b_logOut.TabIndex = 1;
            this.b_logOut.Text = "로그아웃";
            this.b_logOut.UseVisualStyleBackColor = true;
            // 
            // t_idBox
            // 
            this.t_idBox.Location = new System.Drawing.Point(13, 22);
            this.t_idBox.Name = "t_idBox";
            this.t_idBox.Size = new System.Drawing.Size(100, 21);
            this.t_idBox.TabIndex = 2;
            // 
            // t_passwardBox
            // 
            this.t_passwardBox.Location = new System.Drawing.Point(12, 51);
            this.t_passwardBox.Name = "t_passwardBox";
            this.t_passwardBox.Size = new System.Drawing.Size(100, 21);
            this.t_passwardBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_logIn);
            this.groupBox1.Controls.Add(this.t_passwardBox);
            this.groupBox1.Controls.Add(this.b_logOut);
            this.groupBox1.Controls.Add(this.t_idBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 85);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회원 정보";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_find_password);
            this.groupBox2.Controls.Add(this.b_find_id);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 59);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "찾기";
            // 
            // b_find_password
            // 
            this.b_find_password.Location = new System.Drawing.Point(103, 20);
            this.b_find_password.Name = "b_find_password";
            this.b_find_password.Size = new System.Drawing.Size(91, 23);
            this.b_find_password.TabIndex = 5;
            this.b_find_password.Text = "비밀번호 찾기";
            this.b_find_password.UseVisualStyleBackColor = true;
            this.b_find_password.Click += new System.EventHandler(this.b_find_password_Click);
            // 
            // b_find_id
            // 
            this.b_find_id.Location = new System.Drawing.Point(11, 20);
            this.b_find_id.Name = "b_find_id";
            this.b_find_id.Size = new System.Drawing.Size(86, 23);
            this.b_find_id.TabIndex = 4;
            this.b_find_id.Text = "아이디 찾기";
            this.b_find_id.UseVisualStyleBackColor = true;
            this.b_find_id.Click += new System.EventHandler(this.b_find_id_Click);
            // 
            // listBox2
            // 
            this.listBox2.Enabled = false;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(218, 52);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(284, 460);
            this.listBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "입력 기록";
            // 
            // b_register
            // 
            this.b_register.Location = new System.Drawing.Point(427, 12);
            this.b_register.Name = "b_register";
            this.b_register.Size = new System.Drawing.Size(75, 23);
            this.b_register.TabIndex = 4;
            this.b_register.Text = "회원가입";
            this.b_register.UseVisualStyleBackColor = true;
            this.b_register.Click += new System.EventHandler(this.b_register_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(317, 26);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 23);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // t_input_text
            // 
            this.t_input_text.Enabled = false;
            this.t_input_text.Location = new System.Drawing.Point(218, 518);
            this.t_input_text.Name = "t_input_text";
            this.t_input_text.Size = new System.Drawing.Size(234, 21);
            this.t_input_text.TabIndex = 10;
            // 
            // b_send
            // 
            this.b_send.Enabled = false;
            this.b_send.Location = new System.Drawing.Point(459, 518);
            this.b_send.Name = "b_send";
            this.b_send.Size = new System.Drawing.Size(43, 23);
            this.b_send.TabIndex = 11;
            this.b_send.Text = "전송";
            this.b_send.UseVisualStyleBackColor = true;
            this.b_send.Click += new System.EventHandler(this.b_send_Click);
            // 
            // b_join
            // 
            this.b_join.Enabled = false;
            this.b_join.Location = new System.Drawing.Point(12, 518);
            this.b_join.Name = "b_join";
            this.b_join.Size = new System.Drawing.Size(200, 23);
            this.b_join.TabIndex = 12;
            this.b_join.Text = "채팅방 입장";
            this.b_join.UseVisualStyleBackColor = true;
            this.b_join.Click += new System.EventHandler(this.b_join_Click);
            // 
            // l_users
            // 
            this.l_users.Enabled = false;
            this.l_users.FormattingEnabled = true;
            this.l_users.ItemHeight = 12;
            this.l_users.Location = new System.Drawing.Point(12, 316);
            this.l_users.Name = "l_users";
            this.l_users.Size = new System.Drawing.Size(200, 196);
            this.l_users.TabIndex = 13;
            // 
            // l_public
            // 
            this.l_public.Enabled = false;
            this.l_public.FormattingEnabled = true;
            this.l_public.ItemHeight = 12;
            this.l_public.Items.AddRange(new object[] {
            "전체"});
            this.l_public.Location = new System.Drawing.Point(12, 180);
            this.l_public.Name = "l_public";
            this.l_public.Size = new System.Drawing.Size(200, 112);
            this.l_public.TabIndex = 14;
            this.l_public.SelectedIndexChanged += new System.EventHandler(this.l_public_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "접속자 목록";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "채널";
            // 
            // get_while_timer
            // 
            this.get_while_timer.Interval = 3000;
            this.get_while_timer.Tick += new System.EventHandler(this.get_while_timer_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "투명도 조절";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 551);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l_public);
            this.Controls.Add(this.l_users);
            this.Controls.Add(this.b_join);
            this.Controls.Add(this.b_send);
            this.Controls.Add(this.t_input_text);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.b_register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kokonut_talk    denofevil.soft@gmail.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_logIn;
        private System.Windows.Forms.Button b_logOut;
        private System.Windows.Forms.TextBox t_idBox;
        private System.Windows.Forms.TextBox t_passwardBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_find_password;
        private System.Windows.Forms.Button b_find_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_register;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox t_input_text;
        private System.Windows.Forms.Button b_send;
        private System.Windows.Forms.Button b_join;
        private System.Windows.Forms.ListBox l_users;
        private System.Windows.Forms.ListBox l_public;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer get_while_timer;
        public System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label4;
    }
}

