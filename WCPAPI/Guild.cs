using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WCPAPI
{
    public class Guild
    {
        public string name;
        public string realm;
        public int level;
        public int members;
        public int achievementPoints;
        public Emblem emblem;
    }

    public class Emblem
    {
        public int icon;
        public string iconColor;
        public int border;
        public string borderColor;
        public string backgroundColor;
    }
}
