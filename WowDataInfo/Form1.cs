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
            var client = new ApiClient("eu");
            var item = client.GetItem(70534);
            propertyGrid1.SelectedObject = item;

            //var races = client.GetRaces();

            //var classes = client.GetClasses();

            //var grewards = client.GetGuildRewards();

            //var gperks = client.GetGuildPerks();

            //var quest = client.GetQuest(25, Locale.ru_RU);

            //var recipe = client.GetRecipe(2149, Locale.ru_RU);

            //var arena = client.GetArenaLadder("шквал", "2v2");

            // http://eu.battle.net/api/wow/data/guild/perks
            // http://us.battle.net/api/wow/data/character/achievements
            // http://us.battle.net/api/wow/data/guild/achievements
            // http://us.battle.net/api/wow/data/battlegroups/
            // http://us.battle.net/api/wow/pvp/arena/Bloodlust/2v2
            // http://us.battle.net/api/wow/pvp/arena/Bloodlust/2v2?size=5
            // http://us.battle.net/api/wow/data/item/classes
        }
    }
}
