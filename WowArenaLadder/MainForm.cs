using System;
using System.Windows.Forms;
using WCPAPI;

namespace WowArenaLadder
{
    public partial class Form1 : Form
    {
        private ListViewColumnSorter columnSorter;
        private ArenaLadder m_ladder;
        private ApiClient m_client;
        private string m_battlegroup;
        private string m_size = "2v2";

        public Form1()
        {
            InitializeComponent();

            columnSorter = new ListViewColumnSorter();
            listView1.ListViewItemSorter = columnSorter;

            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_client = new ApiClient("eu");

            QueryBGs();
            QueryData();
        }

        private void QueryBGs()
        {
            var bgs = m_client.GetBattlegroups().BGs;

            if (bgs.Length == 0)
            {
                MessageBox.Show("Can't get list of battlegroups, closing...");
                Application.Exit();
                return;
            }

            m_battlegroup = bgs[0].Slug;

            foreach (var bg in bgs)
            {
                var item = battlegroupToolStripMenuItem.DropDownItems.Add(bg.Name) as ToolStripMenuItem;
                item.Tag = bg.Slug;
                item.CheckOnClick = true;
                item.Click += new EventHandler(item_Click);
            }

            (battlegroupToolStripMenuItem.DropDownItems[0] as ToolStripMenuItem).Checked = true;
        }

        void item_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach (ToolStripMenuItem bg in battlegroupToolStripMenuItem.DropDownItems)
            {
                if (bg != sender)
                    bg.Checked = false;
                else
                    m_battlegroup = (string)bg.Tag;
            }

            QueryData();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            columnSorter.SortColumn = e.Column;
            listView1.Sorting = listView1.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            columnSorter.Order = listView1.Sorting;
            listView1.Sort();
        }

        private ListViewItem CreateListViewItemByIndex(int index)
        {
            var team = m_ladder[index];

            return new ListViewItem(new string[]
                {
                    team.Ranking.ToString(),
                    team.Name,
                    team.Realm,
                    team.Side,
                    team.GamesWon.ToString(),
                    team.GamesLost.ToString(),
                    team.Rating.ToString()
                });
        }

        private void teamSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach (ToolStripMenuItem region in teamSizeToolStripMenuItem.DropDownItems)
                if (region != sender)
                    region.Checked = false;

            m_size = (sender as ToolStripMenuItem).Text;

            QueryData();
        }

        private void QueryData()
        {
            m_ladder = m_client.GetArenaLadder(m_battlegroup, m_size, 2000);

            int i = 0;
            foreach (var team in m_ladder)
                listView1.Items.Add(CreateListViewItemByIndex(i++));
        }
    }
}
