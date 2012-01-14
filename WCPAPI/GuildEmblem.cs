using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class GuildEmblem
    {
        [DataMember(Name = "icon")]
        public int Icon { get; private set; }
        [DataMember(Name = "iconColor")]
        public string IconColor { get; private set; }
        [DataMember(Name = "border")]
        public int Border { get; private set; }
        [DataMember(Name = "borderColor")]
        public string BorderColor { get; private set; }
        [DataMember(Name = "backgroundColor")]
        public string BackgroundColor { get; private set; }
    }
}
