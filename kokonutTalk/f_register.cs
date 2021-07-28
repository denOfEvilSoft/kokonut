using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace kokonutTalk
{
    public partial class f_register : Form
    {
        public f_register()
        {
            InitializeComponent();
        }
        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_regi_sign_Click(object sender, EventArgs e)
        {
            if(comb_pass_answer.SelectedIndex == 0)
            {
                MessageBox.Show("질문을 선택해 주세요!");
                return;
            }
            using(MySqlConnection dbConnection = new MySqlConnection(Form1.url))
            {
                try
                {
                    using(MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = dbConnection;
                        cmd.CommandText = "SELECT * FROM user";
                        dbConnection.Open();
                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string id = reader.GetString(0);
                                if (t_regi_id.Text == id)
                                {
                                    MessageBox.Show("중복된 아이디입니다.\n다른 아이디로 가입해주세요!");
                                    return;
                                }
                            }
                        }
                    }
                    
                    string insert_user = "INSERT INTO " + "user" + "(id, password, select_int, answer)" + "VALUES('" + t_regi_id.Text + "','" + t_regi_pass.Text + "','" + comb_pass_answer.SelectedIndex + "','" + t_regi_answer.Text + "')";
                    using (MySqlCommand cmd = new MySqlCommand(insert_user,dbConnection))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("회원가입 완료!");
                        dbConnection.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex + "\nf_register\nb_regi_sign_click");
                    return;
                }
            }
        }

        private void c_show_passward_CheckedChanged(object sender, EventArgs e)
        {
            if(c_show_passward.Checked == true)
            {
                t_regi_pass.PasswordChar = default(char);
            }
            else
            {
                t_regi_pass.PasswordChar = '*';
            }
        }

        private void f_register_Load(object sender, EventArgs e)
        {
            comb_pass_answer.SelectedIndex = 0;
        }
    }
}
