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
    public partial class f_findID : Form
    {
        public f_findID()
        {
            InitializeComponent();
        }

        private void f_findID_Load(object sender, EventArgs e)
        {
            comb_select_answer.SelectedIndex = 0;
        }

        private void b_show_id_Click(object sender, EventArgs e)
        {
            MessageBox.Show("준비중"); // 선택지랑 답이 같다면 답이 여러개 나올 텐데
            return;
            /*
            using (MySqlConnection dbConnection = new MySqlConnection(Form1.url))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    try
                    {
                        dbConnection.Open();
                        cmd.Connection = dbConnection;
                        cmd.CommandText = "SELECT select_int, answer FROM user";
                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            string found_id = "";
                            while (reader.Read())
                            {
                                int select_int = reader.GetInt32(0);
                                string answer = reader.GetString(1);
                                if(select_int == comb_select_answer.SelectedIndex + 1 && t_find_id.Text == answer)
                                {
                                    
                                }
                            }
                            MessageBox.Show("일치하는 아이디 없음!");
                            dbConnection.Close();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex + "\n\nForm1\nb_find_id_Click");
                        return;
                    }
                }
            }
            */
        }
    }
}
