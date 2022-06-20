using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int userId = 0;
            User u = new User();
            u.UserName = "rtjk";
            u.SpeedOfSpeak = 3;
            u.UserId = 1;
            u.Nusach = Nusach.ashcenaz;
            u.Min = Min.bat;
            //User user = new BL.UserBL().SignIn(userId);
            new BL.UserBL().LogIn(u);
            List<string> list = new List<string>();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            List<ChapterOfPrayer> list=  new BL.UserBL().ImportanceList(numericUpDown1.Value, comboBoxPrayers.SelectedIndex, comboBoxNusach.SelectedIndex);
            string s=" ";
            foreach (var item in list)
            {
                s += item.PrayerText + " ";
            }
            richTextBox1.Text = s;
            MessageBox.Show(s);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTIme_SelectedIndexChanged(object sender, EventArgs e)
        {
          // numericUpDown1.Value = comboBoxTime.Text - DateTime.Now;
        }
    }
}
