using System.Runtime.Serialization;

namespace WowDataInfo
{
    [DataContract]
    public class SocketInfo
    {
        [DataMember(Name = "sockets")]
        public Socket[] Sockets { get; private set; }
    }

    [DataContract]
    public class Socket
    {
        [DataMember(Name = "type")]
        public string Type { get; private set; }
    }
}
