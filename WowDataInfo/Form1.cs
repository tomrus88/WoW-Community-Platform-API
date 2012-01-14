using System;
using System.Windows.Forms;
using WCPAPI;

namespace WowDataInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var item = ItemData.Get("eu", 70534);
            propertyGrid1.SelectedObject = item;

            var races = RacesData.Get("eu");

            var classes = ClassesData.Get("eu");

            // http://eu.battle.net/api/wow/data/guild/rewards
            // http://eu.battle.net/api/wow/data/guild/perks
        }
    }
}
