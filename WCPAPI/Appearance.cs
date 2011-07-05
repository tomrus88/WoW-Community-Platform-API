using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Appearance
    {
        [DataMember(Name = "faceVariation")]
        public int FaceVariation;
        [DataMember(Name = "skinColor")]
        public int SkinColor;
        [DataMember(Name = "hairVariation")]
        public int HairVariation;
        [DataMember(Name = "hairColor")]
        public int HairColor;
        [DataMember(Name = "featureVariation")]
        public int FeatureVariation;
        [DataMember(Name = "showHelm")]
        public bool ShowHelm;
        [DataMember(Name = "showCloak")]
        public bool ShowCloak;
    }
}
