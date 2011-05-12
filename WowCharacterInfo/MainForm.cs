using System;
using System.Windows.Forms;

namespace WowCharacterInfo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var character = Character.Get("us", "Uther", "Tieb");

            if (character == null)
                MessageBox.Show("Failed!");
        }
    }
}
