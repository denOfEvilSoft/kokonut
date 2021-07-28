
namespace kokonutTalk
{
    partial class f_register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_close = new System.Windows.Forms.Button();
            this.t_regi_id = new System.Windows.Forms.TextBox();
            this.t_regi_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_regi_sign = new System.Windows.Forms.Button();
            this.c_show_passward = new System.Windows.Forms.CheckBox();
            this.t_regi_answer = new System.Windows.Forms.TextBox();
            this.comb_pass_answer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // b_close
            // 
            this.b_close.Location = new System.Drawing.Point(62, 367);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(100, 23);
            this.b_close.TabIndex = 0;
            this.b_close.Text = "닫기";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // t_regi_id
            // 
            this.t_regi_id.Location = new System.Drawing.Point(32, 156);
            this.t_regi_id.Name = "t_regi_id";
            this.t_regi_id.Size = new System.Drawing.Size(167, 21);
            this.t_regi_id.TabIndex = 1;
            // 
            // t_regi_pass
            // 
            this.t_regi_pass.Location = new System.Drawing.Point(32, 183);
            this.t_regi_pass.Name = "t_regi_pass";
            this.t_regi_pass.PasswordChar = '*';
            this.t_regi_pass.Size = new System.Drawing.Size(167, 21);
            this.t_regi_pass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "약관 들어갈 곳, 주의사항 포함";
            // 
            // b_regi_sign
            // 
            this.b_regi_sign.Location = new System.Drawing.Point(62, 338);
            this.b_regi_sign.Name = "b_regi_sign";
            this.b_regi_sign.Size = new System.Drawing.Size(100, 23);
            this.b_regi_sign.TabIndex = 4;
            this.b_regi_sign.Text = "회원가입";
            this.b_regi_sign.UseVisualStyleBackColor = true;
            this.b_regi_sign.Click += new System.EventHandler(this.b_regi_sign_Click);
            // 
            // c_show_passward
            // 
            this.c_show_passward.AutoSize = true;
            this.c_show_passward.Location = new System.Drawing.Point(62, 210);
            this.c_show_passward.Name = "c_show_passward";
            this.c_show_passward.Size = new System.Drawing.Size(100, 16);
            this.c_show_passward.TabIndex = 5;
            this.c_show_passward.Text = "비밀번호 보기";
            this.c_show_passward.UseVisualStyleBackColor = true;
            this.c_show_passward.CheckedChanged += new System.EventHandler(this.c_show_passward_CheckedChanged);
            // 
            // t_regi_answer
            // 
            this.t_regi_answer.Location = new System.Drawing.Point(32, 298);
            this.t_regi_answer.Name = "t_regi_answer";
            this.t_regi_answer.Size = new System.Drawing.Size(167, 21);
            this.t_regi_answer.TabIndex = 6;
            // 
            // comb_pass_answer
            // 
            this.comb_pass_answer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_pass_answer.FormattingEnabled = true;
            this.comb_pass_answer.Items.AddRange(new object[] {
            "복구용 질문",
            "집 주소",
            "첫 애완동물 이름",
            "졸업 고등학교 이름"});
            this.comb_pass_answer.Location = new System.Drawing.Point(32, 272);
            this.comb_pass_answer.Name = "comb_pass_answer";
            this.comb_pass_answer.Size = new System.Drawing.Size(167, 20);
            this.comb_pass_answer.TabIndex = 7;
            // 
            // f_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 414);
            this.Controls.Add(this.comb_pass_answer);
            this.Controls.Add(this.t_regi_answer);
            this.Controls.Add(this.c_show_passward);
            this.Controls.Add(this.b_regi_sign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_regi_pass);
            this.Controls.Add(this.t_regi_id);
            this.Controls.Add(this.b_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f_register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.f_register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.TextBox t_regi_id;
        private System.Windows.Forms.TextBox t_regi_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_regi_sign;
        private System.Windows.Forms.CheckBox c_show_passward;
        private System.Windows.Forms.TextBox t_regi_answer;
        private System.Windows.Forms.ComboBox comb_pass_answer;
    }
}