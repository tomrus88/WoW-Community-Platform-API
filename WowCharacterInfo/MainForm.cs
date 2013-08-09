using System;
using System.Windows.Forms;
using WCPAPI;

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
            var character = new ApiClient("eu").GetCharacter("Гордунни", "Киллшот", CharacterFields.All, Locale.ru_RU);

            if (character == null)
            {
                MessageBox.Show("Character request failed!");
                return;
            }

            propertyGrid1.SelectedObject = character;
        }
    }
}
