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
            //var item = ItemData.Get("eu", 70534);
            //propertyGrid1.SelectedObject = item;

            //var races = RacesData.Get("eu");

            //var classes = ClassesData.Get("eu");

            //var grewards = GuildRewardsData.Get("eu");

            //var gperks = GuildPerksData.Get("eu");

            //var quest = QuestData.Get("eu", 25, Locale.ru_RU);

            var recipe = RecipeData.Get("eu", 2149, Locale.ru_RU);

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
