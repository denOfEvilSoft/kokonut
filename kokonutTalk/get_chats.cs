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
    class get_chats : Form1
    {
        string selected_room_name;
        public get_chats(string room_name)
        {
            this.selected_room_name = room_name;
        }
    }
}
