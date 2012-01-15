using System;
using System.Windows.Forms;
using WCPAPI;

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
            var guild = new ApiClient("eu").GetGuild("Черный Шрам", "А Нуо", GuildFields.All);

            MessageBox.Show(guild.Name);
        }
    }
}
