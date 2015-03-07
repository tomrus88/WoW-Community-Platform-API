using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class CharacterPet
    {
        [DataMember(Name = "calcSpec")]
        public string CalcSpec { get; private set; }
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "creature")]
        public int Creature { get; private set; }
        [DataMember(Name = "familyId")]
        public int FamilyId { get; private set; }
        [DataMember(Name = "familyName")]
        public string FamilyName { get; private set; }
        [DataMember(Name = "slot")]
        public int Slot { get; private set; }
        [DataMember(Name = "selected")]
        public bool Selected { get; private set; }
        [DataMember(Name = "spec")]
        public CharacterPetSpec Spec { get; private set; }
    }

    [DataContract]
    public class CharacterPetSpec
    {
        [DataMember(Name = "backgroundImage")]
        public string BackgroundImage { get; private set; }
        [DataMember(Name = "description")]
        public string Description { get; private set; }
        [DataMember(Name = "icon")]
        public string Icon { get; private set; }
        [DataMember(Name = "name")]
        public string Name { get; private set; }
        [DataMember(Name = "order")]
        public int Order { get; private set; }
        [DataMember(Name = "role")]
        public string Role { get; private set; }
    }
}
