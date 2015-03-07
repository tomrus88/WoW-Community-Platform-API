using System;
using System.Runtime.Serialization;

namespace WCPAPI
{
    public enum CharacterClass
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
        Monk = 10,
        Druid = 11
    }

    public enum CharacterRace
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
        Worgen = 22,
        Pandaren_Neutral = 24,
        Pandaren_Alliance = 25,
        Pandaren_Horde = 26
    }

    public enum CharacterGender
    {
        Male = 0,
        Female = 1
    }

    [Flags]
    public enum CharacterFields : int
    {
        None = 0,
        Guild = 1,
        Stats = 2,
        Talents = 4,
        Items = 8,
        Reputation = 0x10,
        Titles = 0x20,
        Professions = 0x40,
        Appearance = 0x80,
        Companions = 0x100,
        Mounts = 0x200,
        Pets = 0x400,
        Achievements = 0x800,
        Progression = 0x1000,
        PvP = 0x2000,
        Quests = 0x4000,

        All = 0x7FFF
    }

    [DataContract]
    public class Character
    {
        #pragma warning disable 0649
        [DataMember(Name = "lastModified")]
        private long m_lastModified { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "realm")]
        public string Realm { get; private set; }
        [DataMember(Name = "class")]
        public CharacterClass Class { get; private set; }
        [DataMember(Name = "race")]
        public CharacterRace Race { get; private set; }
        [DataMember(Name = "gender")]
        public CharacterGender Gender { get; private set; }
        [DataMember(Name = "level")]
        public int Level { get; private set; }
        [DataMember(Name = "achievementPoints")]
        public int AchievementPoints { get; private set; }
        [DataMember(Name = "thumbnail")]
        public string Thumbnail { get; private set; }
        [DataMember(Name = "battlegroup")]
        public string Battlegroup { get; private set; }
        [DataMember(Name = "calcClass")]
        public string CalcClass { get; private set; }

        // Optional fields
        [DataMember(Name = "items", IsRequired = false)]
        public CharacterItems Items { get; private set; }
        [DataMember(Name = "stats", IsRequired = false)]
        public CharacterStats Stats { get; private set; }
        [DataMember(Name = "reputation", IsRequired = false)]
        public CharacterReputation[] Reputation { get; private set; }
        [DataMember(Name = "titles", IsRequired = false)]
        public CharacterTitle[] Titles { get; private set; }
        [DataMember(Name = "achievements", IsRequired = false)]
        public Achievements Achievements { get; private set; }
        [DataMember(Name = "hunterPets", IsRequired = false)]
        public CharacterPet[] HunterPets { get; private set; }
        [DataMember(Name = "talents", IsRequired = false)]
        public CharacterSpec[] Talents { get; private set; }
        [DataMember(Name = "mounts", IsRequired = false)]
        public int[] Mounts { get; private set; }
        [DataMember(Name = "companions", IsRequired = false)]
        public int[] Companions { get; private set; }
        [DataMember(Name = "professions", IsRequired = false)]
        public CharacterProfessions Professions { get; private set; }
        [DataMember(Name = "progression", IsRequired = false)]
        public CharacterProgression Progression { get; private set; }
        [DataMember(Name = "guild", IsRequired = false)]
        public CharacterGuild Guild { get; private set; }
        [DataMember(Name = "appearance", IsRequired = false)]
        public CharacterAppearance Appearance { get; private set; }
        [DataMember(Name = "quests", IsRequired = false)]
        public int[] Quests { get; private set; }
        [DataMember(Name = "pvp", IsRequired = false)]
        public CharacterPvp Pvp { get; private set; }

        //audit
        //petSlots
        //pets
        //feed
#pragma warning restore 0649

        private static readonly DateTime baseTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

        public DateTime LastModified
        {
            get
            {
                return baseTime.AddSeconds(m_lastModified / 1000);
            }
        }
    }
}
