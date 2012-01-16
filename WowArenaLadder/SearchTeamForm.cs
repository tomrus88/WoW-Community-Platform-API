using System;
using System.Windows.Forms;

namespace WowArenaLadder
{
    public partial class SearchTeamForm : Form
    {
        public SearchTeamForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mf = Owner as MainForm;
            mf.Search(textBox1.Text, textBox2.Text);
        }

        private void SearchTeamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
                return;

            e.Cancel = true;
            Hide();
            Owner.Activate();
        }
    }
}
