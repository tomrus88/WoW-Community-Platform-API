using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class CharacterAppearance
    {
        [DataMember(Name = "faceVariation")]
        public int FaceVariation { get; private set; }
        [DataMember(Name = "skinColor")]
        public int SkinColor { get; private set; }
        [DataMember(Name = "hairVariation")]
        public int HairVariation { get; private set; }
        [DataMember(Name = "hairColor")]
        public int HairColor { get; private set; }
        [DataMember(Name = "featureVariation")]
        public int FeatureVariation { get; private set; }
        [DataMember(Name = "showHelm")]
        public bool ShowHelm { get; private set; }
        [DataMember(Name = "showCloak")]
        public bool ShowCloak { get; private set; }
    }
}
