using System;
using System.Windows.Forms;

namespace WowGuildInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var guild = GuildInfo.Get("eu", "Черный Шрам", "А Нуо");

            MessageBox.Show(guild.Name);
        }
    }
}
