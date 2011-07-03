using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WowGuildInfo
{
    public class Guild
    {
        public double lastModified;
        public string name;
        public string realm;
        public int level;
        public int side;
        public int achievementPoints;

        public Achievements achievements;
        public List<Member> members;
    }
}
