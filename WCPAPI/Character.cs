using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCPAPI
{
    public enum WowClass
    {
        Warrior = 1,
        Paladin = 2,
        Hunter = 3,
        Rogue = 4,
        Priest = 5,
        DeathKnight = 6,
        Shaman = 7,
        Mage = 8,
        Warlock = 9,
        Druid = 11
    }

    public enum WowRace
    {
        Human = 1,
        Orc = 2,
        Dwarf = 3,
        NightElf = 4,
        Undead = 5,
        Tauren = 6,
        Gnome = 7,
        Troll = 8,
        Goblin = 9,
        BloodElf = 10,
        Draenei = 11,
        Worgen = 22
    }

    public enum WowGender
    {
        Male = 0,
        Female = 1
    }

    [DataContract]
    public class Character
    {
        #pragma warning disable 0649
        // fields for failed response
        [DataMember(Name = "status", IsRequired = false)]
        public string Status { get; private set; }
        [DataMember(Name = "reason", IsRequired = false)]
        public string Reason { get; private set; }

        [DataMember(Name = "lastModified")]
        private double m_lastModified { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "realm")]
        public string Realm { get; private set; }
        [DataMember(Name = "class")]
        public WowClass Class { get; private set; }
        [DataMember(Name = "race")]
        public WowRace Race { get; private set; }
        [DataMember(Name = "gender")]
        public WowGender Gender { get; private set; }
        [DataMember(Name = "level")]
        public int Level { get; private set; }
        [DataMember(Name = "achievementPoints")]
        public int AchievementPoints { get; private set; }
        [DataMember(Name = "thumbnail")]
        public string Thumbnail { get; private set; }

        // Optional fields
        [DataMember(Name = "items", IsRequired = false)]
        public Items Items { get; private set; }
        [DataMember(Name = "stats", IsRequired = false)]
        public Stats Stats { get; private set; }
        [DataMember(Name = "reputation", IsRequired = false)]
        public IList<Reputation> Reputation { get; private set; }
        [DataMember(Name = "titles", IsRequired = false)]
        public IList<Title> Titles { get; private set; }
        [DataMember(Name = "achievements", IsRequired = false)]
        public Achievements Achievements { get; private set; }
        [DataMember(Name = "pets", IsRequired = false)]
        public IList<Pet> Pets { get; private set; }
        [DataMember(Name = "talents", IsRequired = false)]
        public IList<Spec> Talents { get; private set; }
        [DataMember(Name = "mounts", IsRequired = false)]
        public IList<int> Mounts { get; private set; }
        [DataMember(Name = "companions", IsRequired = false)]
        public IList<int> Companions { get; private set; }
        [DataMember(Name = "professions", IsRequired = false)]
        public Professions Professions { get; private set; }
        [DataMember(Name = "progression", IsRequired = false)]
        public Progression Progression { get; private set; }
        [DataMember(Name = "guild", IsRequired = false)]
        public Guild Guild { get; private set; }
        [DataMember(Name = "appearance", IsRequired = false)]
        public Appearance Appearance { get; private set; }
        #pragma warning restore 0649

        public DateTime LastModified
        {
            get
            {
                DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                return origin.AddSeconds(m_lastModified / 1000.0f);
            }
        }
    }
}
