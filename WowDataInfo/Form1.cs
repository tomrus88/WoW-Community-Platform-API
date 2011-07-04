using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            // http://eu.battle.net/api/wow/data/character/races
            // http://eu.battle.net/api/wow/data/character/classes
            // http://eu.battle.net/api/wow/data/guild/rewards
            // http://eu.battle.net/api/wow/data/guild/perks
            // http://eu.battle.net/api/wow/data/item/<id>
        }
    }
}
