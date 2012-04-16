using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCPAPI;

namespace WowArenaLadder
{
    public partial class MainForm : Form
    {
        private ListViewColumnSorter columnSorter;
        private ApiClient m_client;
        private string m_battlegroupSlug;
        private string m_battlegroupName;
        private string m_size = "2v2";
        private FilterForm m_filterForm = new FilterForm();
        private ContextMenuStrip m_charMenu = new ContextMenuStrip();
        private SearchTeamForm m_searchForm = new SearchTeamForm();

        public ArenaLadder Ladder { get; private set; }

        public MainForm()
        {
            InitializeComponent();

            columnSorter = new ListViewColumnSorter();
            ladderView.ListViewItemSorter = columnSorter;

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
        }

        private void QueryBGs()
        {
            Task<Battlegroups>.Factory.StartNew(() => m_client.GetBattlegroups()).ContinueWith(task => FillMenuItems(task.Result));
        }

        delegate void AddBattlegroups(Battlegroups bgs);

        private void FillMenuItems(Battlegroups bgs)
        {
            if (this.InvokeRequired)
            {
                Invoke(new AddBattlegroups(FillMenuItems), bgs);
            }
            else
            {
                battlegroupToolStripMenuItem.DropDownItems.Clear();

                if (bgs.BGs.Length == 0)
                {
                    MessageBox.Show("Can't get list of battlegroups!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                m_battlegroupSlug = bgs.BGs[0].Slug;
                m_battlegroupName = bgs.BGs[0].Name;

                foreach (var bg in bgs.BGs)
                {
                    var item = battlegroupToolStripMenuItem.DropDownItems.Add(bg.Name) as ToolStripMenuItem;
                    item.Tag = bg.Slug;
                    item.Click += new EventHandler(bgToolStripItem_Click);
                }

                (battlegroupToolStripMenuItem.DropDownItems[0] as ToolStripMenuItem).Checked = true;
            }

            QueryData();
        }

        private void bgToolStripItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem bg in battlegroupToolStripMenuItem.DropDownItems)
            {
                if (bg != sender)
                    bg.Checked = false;
                else
                {
                    bg.Checked = true;
                    m_battlegroupSlug = (string)bg.Tag;
                    m_battlegroupName = (string)bg.Text;
                }
            }

            QueryData();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            columnSorter.SortColumn = e.Column;
            ladderView.Sorting = ladderView.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            columnSorter.Order = ladderView.Sorting;
            ladderView.Sort();
        }

        private ListViewItem CreateListViewItemFromTeam(ArenaTeam team)
        {
            var item = new ListViewItem(new string[]
                {
                    team.Ranking.ToString(),
                    team.Name,
                    team.Realm,
                    team.Side,
                    team.SessionGamesWon.ToString(),
                    team.SessionGamesLost.ToString(),
                    team.Rating.ToString(),
                });

            item.Tag = team;
            return item;
        }

        private void teamSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem teamsize in teamSizeToolStripMenuItem.DropDownItems)
            {
                if (teamsize != sender)
                    teamsize.Checked = false;
                else
                {
                    teamsize.Checked = true;
                    m_size = teamsize.Text;
                }
            }

            QueryData();
        }

        private void QueryData()
        {
            Task<ArenaLadder>.Factory.StartNew(() => m_client.GetArenaLadder(m_battlegroupSlug, m_size, 2000)).ContinueWith(task => FillListView(task.Result));
        }

        delegate void AddListViewItems(ArenaLadder ladder);

        private void FillListView(ArenaLadder ladder)
        {
            if (ladderView.InvokeRequired)
            {
                ladderView.Invoke(new AddListViewItems(FillListView), ladder);
            }
            else
            {
                Ladder = ladder;

                m_filterForm.FillComboBox(Ladder);

                if (Ladder.ArenaTeams == null)
                {
                    ladderView.Items.Clear();
                    Text = String.Format("WoW Arena Ladder - {0}-{1}: 0 of 0 teams displayed", m_battlegroupName, m_client.Region.ToUpper());
                    return;
                }

                ladderView.BeginUpdate();

                ladderView.Items.Clear();

                Task<ListViewItem[]>.Factory.StartNew(() =>
                    {
                        ListViewItem[] items = new ListViewItem[Ladder.ArenaTeams.Length];
                        for (int i = 0; i < items.Length; ++i)
                            items[i] = CreateListViewItemFromTeam(Ladder.ArenaTeams[i]);
                        return items;
                    }).ContinueWith((t) =>
                    {
                        for (int i = 0; i < t.Result.Length; ++i)
                            AddListViewItem(t.Result[i]);
                    }).ContinueWith((t) => Finish());
            }
        }

        delegate void AddListViewItemD(ListViewItem item);

        private void AddListViewItem(ListViewItem item)
        {
            if (ladderView.InvokeRequired)
            {
                ladderView.Invoke(new AddListViewItemD(AddListViewItem), item);
            }
            else
            {
                ladderView.Items.Add(item);
            }
        }

        delegate void FinishD();

        private void Finish()
        {
            if (this.InvokeRequired)
            {
                Invoke(new FinishD(Finish));
            }
            else
            {
                ladderView.EndUpdate();

                Text = String.Format("WoW Arena Ladder - {0}-{1}: {2} of {3} teams displayed", m_battlegroupName, m_client.Region.ToUpper(), ladderView.Items.Count, Ladder.ArenaTeams.Length);
            }
        }

        private void ladderView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private static Dictionary<CharacterClass, Image> ImageByClass = new Dictionary<CharacterClass, Image>
        {
            { CharacterClass.Warrior, Properties.Resources.classes_warrior },
            { CharacterClass.Paladin, Properties.Resources.classes_paladin },
            { CharacterClass.Hunter, Properties.Resources.classes_hunter },
            { CharacterClass.Rogue, Properties.Resources.classes_rogue },
            { CharacterClass.Priest, Properties.Resources.classes_priest },
            { CharacterClass.DeathKnight, Properties.Resources.classes_deathknight },
            { CharacterClass.Shaman, Properties.Resources.classes_shaman },
            { CharacterClass.Mage, Properties.Resources.classes_mage },
            { CharacterClass.Warlock, Properties.Resources.classes_warlock },
            { CharacterClass.Druid, Properties.Resources.classes_druid }
        };

        private void ladderView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (e.Item.Selected)
                //if ((e.ItemState & ListViewItemStates.Selected) != 0)
                    e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);

                e.Graphics.DrawString(e.SubItem.Text, ladderView.Font, new SolidBrush(ladderView.ForeColor), e.Bounds);

                var team = e.Item.Tag as ArenaTeam;

                var sortedMembers = team.Members.OrderByDescending(k => k.PersonalRating).ToArray();

                var height = e.Bounds.Height;

                for (int i = 0; i < team.TeamSize && i < sortedMembers.Length; ++i)
                    e.Graphics.DrawImage(ImageByClass[sortedMembers[i].Character.Class], e.Bounds.Right - (i + 1) * height, e.Bounds.Y, height, height);
            }
            else
                e.DrawDefault = true;
        }

        private void ladderView_MouseMove(object sender, MouseEventArgs e)
        {
            ListViewItem item = ladderView.GetItemAt(e.X, e.Y);
            if (item != null)
                ladderView.Invalidate(item.Bounds);
        }

        private void ladderView_SizeChanged(object sender, EventArgs e)
        {
            ladderView.Invalidate();
        }

        private void ladderView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = ladderView.GetItemAt(e.X, e.Y);
            if (item != null)
            {
                var team = item.Tag as ArenaTeam;

                Process.Start(String.Format("http://{0}.battle.net/wow/en/arena/{1}/{2}v{2}/{3}/", m_client.Region, team.Realm, team.TeamSize, team.Name));
            }
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem region in regionToolStripMenuItem.DropDownItems)
            {
                if (region != sender)
                    region.Checked = false;
                else
                {
                    region.Checked = true;
                    m_client.Region = (string)region.Tag;
                }
            }

            QueryBGs();
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_filterForm.Show(this);
        }

        public void ApplyFilter(int minRating, string realm, bool incomplete)
        {
            if (Ladder.ArenaTeams == null)
                return;

            ladderView.BeginUpdate();

            ladderView.Items.Clear();

            foreach (var team in Ladder.ArenaTeams)
                if (team.Rating >= minRating && (string.IsNullOrEmpty(realm) || team.Realm == realm) && (!incomplete || team.Members.Length >= team.TeamSize))
                    ladderView.Items.Add(CreateListViewItemFromTeam(team));

            ladderView.EndUpdate();

            Text = String.Format("WoW Arena Ladder - {0}-{1}: {2} of {3} teams displayed", m_battlegroupName, m_client.Region.ToUpper(), ladderView.Items.Count, Ladder.ArenaTeams.Length);
        }

        private void ladderView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewHitTestInfo hitTestInfo = ladderView.HitTest(e.X, e.Y);
                if (hitTestInfo.Item != null)
                {
                    m_charMenu.Items.Clear();
                    var team = hitTestInfo.Item.Tag as ArenaTeam;
                    foreach (var member in team.Members)
                    {
                        m_charMenu.Items.Add(member.Character.Name, ImageByClass[member.Character.Class], (o, s) =>
                        {
                            Process.Start(String.Format("http://{0}.battle.net/wow/en/character/{1}/{2}/advanced", m_client.Region, member.Character.Realm, member.Character.Name));
                        });
                    }

                    m_charMenu.Show(ladderView, e.X, e.Y);
                }
            }
        }

        public void Search(string teamName, string characterName)
        {
            if (string.IsNullOrEmpty(teamName) && string.IsNullOrEmpty(characterName))
                return;

            ListViewItem found = null;

            foreach (ListViewItem item in ladderView.Items)
            {
                var team = item.Tag as ArenaTeam;

                if (!string.IsNullOrEmpty(teamName))
                {
                    if (team.Name == teamName)
                    {
                        found = item;
                        break;
                    }
                }
                else if (!string.IsNullOrEmpty(characterName))
                {
                    if (team.Members.Any(m => m.Character.Name == characterName))
                    {
                        found = item;
                        break;
                    }
                }
            }

            if (found != null)
            {
                found.Selected = true;
                ladderView.EnsureVisible(found.Index);
            }
            else
            {
                MessageBox.Show("Nothing found!");
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_searchForm.Show(this);
        }
    }
}
