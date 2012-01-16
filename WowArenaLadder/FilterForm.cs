using System;
using System.Linq;
using System.Windows.Forms;
using WCPAPI;

namespace WowArenaLadder
{
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mf = Owner as MainForm;

            int minRating;

            int.TryParse(textBox1.Text, out minRating);

            mf.ApplyFilter(minRating, (string)comboBox1.SelectedItem, checkBox1.Checked);
        }

        private void FilterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
                return;

            e.Cancel = true;
            Hide();
            Owner.Activate();
        }

        public void FillComboBox(ArenaLadder ladder)
        {
            if (ladder.ArenaTeams == null)
                return;

            var realms = ladder.ArenaTeams.Select(team => team.Realm).Distinct().ToArray();

            comboBox1.Items.Clear();
            comboBox1.Items.Insert(0, "");
            comboBox1.Items.AddRange(realms);
        }
    }
}
