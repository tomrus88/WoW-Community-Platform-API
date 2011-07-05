using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Spec
    {
        [DataMember(Name = "selected")]
        public bool Selected { get; private set; }
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "icon")]
        public string Icon { get; private set; }
        [DataMember(Name = "build")]
        public string Build { get; private set; }
        [DataMember(Name = "trees")]
        public IList<Tree> Trees { get; private set; }
        [DataMember(Name = "glyphs")]
        public Glyphs Glyphs { get; private set; }
    }

    [DataContract]
    public class Tree
    {
        [DataMember(Name = "points")]
        public string Points { get; private set; }
        [DataMember(Name = "total")]
        public int Total { get; private set; }
    }

    [DataContract]
    public class Glyph
    {
        [DataMember(Name = "glyph")]
        public int Id { get; private set; }
        [DataMember(Name = "item")]
        public int Item { get; private set; }
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "icon")]
        public string Icon { get; private set; }
    }

    [DataContract]
    public class Glyphs
    {
        [DataMember(Name = "prime")]
        public IList<Glyph> Prime { get; private set; }
        [DataMember(Name = "major")]
        public IList<Glyph> Major { get; private set; }
        [DataMember(Name = "minor")]
        public IList<Glyph> Minor { get; private set; }
    }
}
