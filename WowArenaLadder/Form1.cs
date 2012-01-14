using System;
using System.Windows.Forms;
using WCPAPI;

namespace WowArenaLadder
{
    public partial class Form1 : Form
    {
        private ListViewColumnSorter columnSorter;
        private ArenaLadder m_ladder;

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
            QueryData("2v2");
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

            var size = (sender as ToolStripMenuItem).Text;

            QueryData(size);
        }

        private void QueryData(string size)
        {
            m_ladder = ArenaLadderData.Get("eu", "шквал", size, 2000);

            int i = 0;
            foreach (var team in m_ladder)
                listView1.Items.Add(CreateListViewItemByIndex(i++));
        }
    }
}
