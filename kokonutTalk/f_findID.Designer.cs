
namespace kokonutTalk
{
    partial class f_findID
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
            this.label1 = new System.Windows.Forms.Label();
            this.comb_select_answer = new System.Windows.Forms.ComboBox();
            this.t_find_id = new System.Windows.Forms.TextBox();
            this.b_show_id = new System.Windows.Forms.Button();
            this.b_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "가입시 선택한 질문을 선택해 주세요";
            // 
            // comb_select_answer
            // 
            this.comb_select_answer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_select_answer.FormattingEnabled = true;
            this.comb_select_answer.Items.AddRange(new object[] {
            "집 주소",
            "첫 애완동물 이름",
            "졸업 고등학교 이름"});
            this.comb_select_answer.Location = new System.Drawing.Point(32, 111);
            this.comb_select_answer.Name = "comb_select_answer";
            this.comb_select_answer.Size = new System.Drawing.Size(167, 20);
            this.comb_select_answer.TabIndex = 11;
            // 
            // t_find_id
            // 
            this.t_find_id.Location = new System.Drawing.Point(32, 183);
            this.t_find_id.Name = "t_find_id";
            this.t_find_id.Size = new System.Drawing.Size(167, 21);
            this.t_find_id.TabIndex = 10;
            // 
            // b_show_id
            // 
            this.b_show_id.Location = new System.Drawing.Point(68, 210);
            this.b_show_id.Name = "b_show_id";
            this.b_show_id.Size = new System.Drawing.Size(100, 23);
            this.b_show_id.TabIndex = 9;
            this.b_show_id.Text = "아이디 찾기";
            this.b_show_id.UseVisualStyleBackColor = true;
            this.b_show_id.Click += new System.EventHandler(this.b_show_id_Click);
            // 
            // b_close
            // 
            this.b_close.Location = new System.Drawing.Point(68, 373);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(100, 23);
            this.b_close.TabIndex = 8;
            this.b_close.Text = "닫기";
            this.b_close.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "가입시 입력한 답을 입력해 주세요";
            // 
            // f_findID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 433);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comb_select_answer);
            this.Controls.Add(this.t_find_id);
            this.Controls.Add(this.b_show_id);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f_findID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f_findID";
            this.Load += new System.EventHandler(this.f_findID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comb_select_answer;
        private System.Windows.Forms.TextBox t_find_id;
        private System.Windows.Forms.Button b_show_id;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Label label2;
    }
}