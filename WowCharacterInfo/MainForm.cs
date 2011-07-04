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
            var character = CharacterInfo.Get("eu", "Черный Шрам", "Киллшот");

            if (character.Status == "nok")
                MessageBox.Show(character.Reason);

            propertyGrid1.SelectedObject = character;
        }
    }
}
