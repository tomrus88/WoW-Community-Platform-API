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
        public double lastModified { get; private set; }
        [DataMember]
        public string name { get; private set; }
        [DataMember]
        public string realm { get; private set; }
        [DataMember]
        public WowClass @class { get; private set; }
        [DataMember]
        public WowRace race { get; private set; }
        [DataMember]
        public WowGender gender { get; private set; }
        [DataMember]
        public int level { get; private set; }
        [DataMember]
        public int achievementPoints { get; private set; }
        [DataMember]
        public string thumbnail { get; private set; }
        [DataMember]
        public Items items { get; private set; }
        [DataMember]
        public Stats stats { get; private set; }
        [DataMember]
        public List<Reputation> reputation { get; private set; }
        [DataMember]
        public List<Title> titles { get; private set; }
        [DataMember]
        public Achievements achievements { get; private set; }
        [DataMember]
        public List<Pet> pets { get; private set; }
        [DataMember]
        public List<Spec> talents { get; private set; }
        [DataMember]
        public List<int> mounts { get; private set; }
        [DataMember]
        public List<int> companions { get; private set; }
        [DataMember]
        public Professions professions { get; private set; }
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
