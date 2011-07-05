using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Spec
    {
        [DataMember(Name = "selected")]
        public bool Selected;
        [DataMember(Name = "name")]
        public string Name;
        [DataMember(Name = "icon")]
        public string Icon;
        [DataMember(Name = "build")]
        public string Build;
        [DataMember(Name = "trees")]
        public IList<Tree> Trees;
        [DataMember(Name = "glyphs")]
        public Glyphs Glyphs;
    }

    [DataContract]
    public class Tree
    {
        [DataMember(Name = "points")]
        public string Points;
        [DataMember(Name = "total")]
        public int Total;
    }

    [DataContract]
    public class Glyph
    {
        [DataMember(Name = "glyph")]
        public int Id;
        [DataMember(Name = "item")]
        public int Item;
        [DataMember(Name = "name")]
        public string Name;
        [DataMember(Name = "icon")]
        public string Icon;
    }

    [DataContract]
    public class Glyphs
    {
        [DataMember(Name = "prime")]
        public IList<Glyph> Prime;
        [DataMember(Name = "major")]
        public IList<Glyph> Major;
        [DataMember(Name = "minor")]
        public IList<Glyph> Minor;
    }
}
