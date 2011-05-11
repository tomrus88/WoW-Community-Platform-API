using System;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace WowRealmStatus
{
    public partial class Form1 : Form
    {
        private ListViewColumnSorter columnSorter;
        private string m_region;

        public Form1()
        {
            InitializeComponent();

            // Create an instance of a ListView column sorter and assign it to the ListView control.
            columnSorter = new ListViewColumnSorter();
            listView1.ListViewItemSorter = columnSorter;

            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_region = "eu";

            FillListView();
        }

        private void FillListView()
        {
            WebClient client = new WebClient();
            client.DownloadDataCompleted += new DownloadDataCompletedEventHandler(client_DownloadDataCompleted);
            client.DownloadDataAsync(new Uri(String.Format("http://{0}.battle.net/api/wow/realm/status", m_region)));
        }

        void client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            listView1.Items.Clear();

            try
            {
                var dataStr = Encoding.UTF8.GetString(e.Result);

                var serializer = new JavaScriptSerializer();
                var status = serializer.Deserialize<RealmStatus>(dataStr);

                foreach (var realm in status.realms)
                    listView1.Items.Add(new ListViewItem(new string[] { realm.name, realm.slug, realm.type, realm.population, realm.queue.ToString(), realm.status.ToString() }));
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                if (exc.InnerException != null)
                    MessageBox.Show(exc.InnerException.Message);
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            columnSorter.SortColumn = e.Column;
            listView1.Sorting = listView1.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            columnSorter.Order = listView1.Sorting;
            listView1.Sort();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillListView();
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem region in regionToolStripMenuItem.DropDownItems)
            {
                if (region != sender)
                    region.Checked = false;
                else
                    m_region = (string)region.Tag;
            }

            FillListView();
        }
    }
}
