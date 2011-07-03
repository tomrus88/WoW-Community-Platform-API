using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WowCharacterInfo
{
    public class Professions
    {
        public Profession[] primary;
        public Profession[] secondary;
    }

    public class Profession
    {
        public int id;
        public string name;
        public string icon;
        public int rank;
        public int max;
        public List<int> recipes;
    }
}
