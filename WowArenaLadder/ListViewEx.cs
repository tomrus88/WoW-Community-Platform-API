using System.Windows.Forms;

namespace WowArenaLadder
{
    class ListViewEx : ListView
    {
        public ListViewEx()
            : base()
        {
            DoubleBuffered = true;
        }
    }
}
