using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class CharacterSpec
    {
        [DataMember(Name = "selected")]
        public bool Selected { get; private set; }
        [DataMember(Name = "calcGlyph")]
        public string CalcGlyph { get; private set; }
        [DataMember(Name = "calcSpec")]
        public string CalcSpec { get; private set; }
        [DataMember(Name = "calcTalent")]
        public string CalcTalent { get; private set; }
        [DataMember(Name = "talents")]
        public Talent[] Talents { get; private set; }
        [DataMember(Name = "glyphs")]
        public Glyphs Glyphs { get; private set; }
        [DataMember(Name = "spec")]
        public Spec Spec { get; private set; }
    }

    [DataContract]
    public class Spec
    {
        [DataMember(Name = "backgroundImage")]
        public string BackgroundImage;
        [DataMember(Name = "description")]
        public string Description;
        [DataMember(Name = "icon")]
        public string Icon;
        [DataMember(Name = "name")]
        public string Name;
        [DataMember(Name = "order")]
        public int Order;
        [DataMember(Name = "role")]
        public string Role;
    }

    [DataContract]
    public class Talent
    {
        [DataMember(Name = "column")]
        public int Column { get; private set; }
        [DataMember(Name = "spell")]
        public TalentSpell Spell { get; private set; }
        [DataMember(Name = "tier")]
        public int Tier { get; private set; }
    }

    [DataContract]
    public class TalentSpell
    {
        [DataMember(Name = "castTime")]
        public string CastTime;
        [DataMember(Name = "description")]
        public string Description;
        [DataMember(Name = "icon")]
        public string Tcon;
        [DataMember(Name = "id")]
        public int Id;
        [DataMember(Name = "name")]
        public string Name;
        [DataMember(Name = "subtext")]
        public string Subtext;
        [DataMember(Name = "powerCost")]
        public string PowerCost;
        [DataMember(Name = "range")]
        public string Range;
        [DataMember(Name = "cooldown")]
        public string Cooldown;

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
        [DataMember(Name = "major")]
        public Glyph[] Major { get; private set; }
        [DataMember(Name = "minor")]
        public Glyph[] Minor { get; private set; }
    }
}
