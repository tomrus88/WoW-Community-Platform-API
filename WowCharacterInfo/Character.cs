using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WowCharacterInfo
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
        // fields for failed response
#pragma warning disable 0649
        [DataMember(IsRequired = false)]
        public string status;
        [DataMember(IsRequired = false)]
        public string reason;

        [DataMember]
        public double lastModified;
        [DataMember]
        public string name;
        [DataMember]
        public string realm;
        [DataMember]
        public WowClass @class;
        [DataMember]
        public WowRace race;
        [DataMember]
        public WowGender gender;
        [DataMember]
        public int level;
        [DataMember]
        public int achievementPoints;
        [DataMember]
        public string thumbnail;
        [DataMember]
        public Items items;
        [DataMember]
        public Stats stats;
        [DataMember]
        public List<Reputation> reputation;
        [DataMember]
        public List<Title> titles;
        [DataMember]
        public Achievements achievements;
        [DataMember]
        public List<Pet> pets;
        [DataMember]
        public List<Spec> talents;
        [DataMember]
        public List<int> mounts;
#pragma warning restore 0649

        public DateTime LastModified
        {
            get
            {
                DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                return origin.AddSeconds(lastModified / 1000.0f);
            }
        }
    }
}
