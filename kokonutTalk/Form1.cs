using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

using MySql.Data.MySqlClient;

namespace kokonutTalk
{
    public partial class Form1 : Form
    {
        public static String url = "SERVER = 112.184.93.163; USER = root; DATABASE = kokonut; PORT = 3306; PASSWORD = qwerty614;";
        public Form1()
        {
            InitializeComponent();
        }

        private void b_register_Click(object sender, EventArgs e)
        {
            using (f_register newForm = new f_register())
            {
                newForm.ShowDialog();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double opa = (trackBar1.Value + 1) * 0.1;
            if (opa > 1)
            {
                opa = 1;
            }
            this.Opacity = opa;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Maximum = 10;
            trackBar1.Value = 10;
        }

        private void b_logIn_Click(object sender, EventArgs e)
        {
            string id = t_idBox.Text;
            string passward = t_passwardBox.Text;
            bool match = false;
            using (MySqlConnection dbConnection = new MySqlConnection(url))
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = dbConnection;
                        dbConnection.Open();
                        cmd.CommandText = "SELECT id FROM user";
                        string get_id = "";
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                get_id = reader.GetString(0);
                                if (get_id == id)
                                {
                                    match = true;
                                    break;
                                }
                            }
                            if (match == false)
                            {
                                MessageBox.Show("일치하는 아이디가 없어요");
                                dbConnection.Close();
                                return;
                            }
                        }
                        cmd.CommandText =
                            "SELECT password " +
                            "FROM user " +
                            "WHERE id = '" + get_id + "'";
                        object pass = cmd.ExecuteScalar();
                        passward = Convert.ToString(pass);
                        if (passward != t_passwardBox.Text)
                        {
                            MessageBox.Show("비밀번호가 틀림");
                            dbConnection.Close();
                            return;
                        }
                        MessageBox.Show("로그인 성공!");
                        b_logIn.Enabled = false;
                        b_logOut.Enabled = true;
                        l_public.Enabled = true;
                        b_join.Enabled = true;
                        t_input_text.Enabled = true;
                        b_send.Enabled = true;
                        t_idBox.Enabled = false;
                        t_passwardBox.Enabled = false;
                        dbConnection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "\n+nForm1\nb_logIng_Click");
                    return;
                }
            }
        }

        private void b_find_password_Click(object sender, EventArgs e)
        {

        }

        private void b_find_id_Click(object sender, EventArgs e)
        {
            using (f_findID id = new f_findID())
            {
                id.ShowDialog();
            }
        }
        private string[] last_input = new string[2];
        // 채팅장 입징버튼 누를 시
        private void b_join_Click(object sender, EventArgs e)
        {
            using (MySqlConnection dbConnection = new MySqlConnection(Form1.url))
            {
                if (b_join.Text == "채팅방 입장")
                {
                    using (MySqlCommand cmd = new MySqlCommand()) 
                    {
                        cmd.Connection = dbConnection;
                        dbConnection.Open();
                        cmd.CommandText = 
                            "SELECT * FROM (SELECT * FROM input_log_all " +
                            "ORDER BY date " +
                            "DESC LIMIT 19)a ORDER BY date ASC LIMIT 19";
                        // 채팅 기록 전부 가져옴. 최근 19개만 가져오도록 수정할 것
                        // 성공
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string id = reader.GetString(0);
                                double date = reader.GetDouble(1);
                                string convert_date = UnixTimeStampToDateTime(date).ToString();
                                string input = reader.GetString(2);
                                
                                last_input[0] = Convert.ToString(date);
                                last_input[1] = input;

                                string combine = id + " (" + convert_date + ")";
                                string combine_input = "   : " + input;
                                listBox2.Items.Add(combine);
                                listBox2.Items.Add(combine_input);
                            }
                        }
                        cmd.CommandText = "INSERT IGNORE INTO " + "user_list_all" + "(username)" + // 참여자 목록에 추가
                            "VALUES('" + t_idBox.Text + "')";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "SELECT username FROM user_list_all";
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string ids = reader.GetString(0);
                                l_users.Items.Add(ids);
                            }
                        }
                        // 타이머 시작
                        get_while_timer.Start();
                        b_join.Text = "채팅방 퇴장";
                        l_public.Enabled = false;
                    }
                }
                else
                {
                    // 퇴장시 참여자 목록에서 삭제
                    string delete_db = "DELETE FROM user_list_all WHERE username = " + t_idBox.Text;
                    using (MySqlCommand cmd = new MySqlCommand(delete_db, dbConnection))
                    {
                        get_while_timer.Stop();
                        dbConnection.Close();
                        l_users.Items.Clear();
                        listBox2.Items.Clear();
                        b_join.Text = "채팅방 입장";
                        l_public.Enabled = true;
                    }
                }
            }
        }

        private void l_public_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 개인방 이랑 퍼블릭이랑 같이 선택 되는거 풀어줘야 함
        }
        protected void set_string(string text)
        {
            listBox2.Items.Add(text);
        }
        protected static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        private void b_send_Click(object sender, EventArgs e)
        {
            send_message snd = new send_message();
            snd.sending(t_idBox.Text, t_input_text.Text);
            t_input_text.Text = "";
        }

        // 채팅기로 가져오는 타이머 틱 부분
        private void get_while_timer_Tick(object sender, EventArgs e)
        {
            get_news();
        }
        public void get_news()
        {
            using (MySqlConnection dbConnection = new MySqlConnection(url))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = dbConnection;
                    dbConnection.Open();
                    cmd.CommandText = "SELECT date FROM input_log_all ORDER BY date DESC LIMIT 1";
                    object obj_value = cmd.ExecuteScalar();
                    double date = Convert.ToDouble(obj_value);
                    string convert_date = UnixTimeStampToDateTime(date).ToString();
                    string date_con = Convert.ToString(date);

                    cmd.CommandText = "SELECT input FROM input_log_all ORDER BY date DESC LIMIT 1";
                    object obj_value2 = cmd.ExecuteScalar();
                    string input = Convert.ToString(obj_value2);
                    if (date_con != last_input[0] && input != last_input[1])
                    {
                        cmd.CommandText = "SELECT id FROM input_log_all ORDER BY date DESC LIMIT 1";
                        string id = Convert.ToString(cmd.ExecuteScalar());
                        string combine = id + " (" + convert_date + ")";
                        string combine_input = "   : " + input;

                        listBox2.Items.RemoveAt(0);
                        listBox2.Items.RemoveAt(1);
                        listBox2.Items.Add(combine);
                        listBox2.Items.Add(combine_input);
                        last_input[0] = date.ToString();
                        last_input[1] = input;
                    }
                    dbConnection.Close();
                }
            }
        }
        public int UnixTimeNow()
        {
            var timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
            return (int)timeSpan.TotalSeconds;
        }
        int second_timer = 3;
    }
}
