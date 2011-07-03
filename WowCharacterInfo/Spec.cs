using System.Collections.Generic;

namespace WowCharacterInfo
{
    public class Spec
    {
        public bool selected;
        public string name;
        public string icon;
        public string build;
        public List<Tree> trees;
        public Glyphs glyphs;
    }

    public class Tree
    {
        public string points;
        public int total;
    }

    public class Glyph
    {
        public int glyph;
        public int item;
        public string name;
        public string icon;
    }

    public class Glyphs
    {
        public List<Glyph> prime;
        public List<Glyph> major;
        public List<Glyph> minor;
    }
}
