using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Progression : ICollection
    {
        [DataMember(Name = "raids")]
        public IList<Raid> Raids;

        public void CopyTo(Array array, int index)
        {
            Raids.CopyTo((Raid[])array, index);
        }

        public int Count
        {
            get { return Raids.Count; }
        }

        public bool IsSynchronized
        {
            get { return false; }
        }

        public object SyncRoot
        {
            get { return null; }
        }

        public IEnumerator GetEnumerator()
        {
            return Raids.GetEnumerator();
        }
    }

    [DataContract]
    public class Raid
    {
        [DataMember(Name = "name")]
        public string Name;
        [DataMember(Name = "normal")]
        public int Bormal;
        [DataMember(Name = "heroic")]
        public int Heroic;
        [DataMember(Name = "id")]
        public int Id;
        [DataMember(Name = "bosses")]
        public IList<Boss> Bosses;

        public override string ToString()
        {
            return String.Format("Id {0}, Name {1}", Id, Name);
        }
    }

    [DataContract]
    public class Boss
    {
        [DataMember(Name = "name")]
        public string Name;
        [DataMember(Name = "normalKills")]
        public int NormalKills;
        [DataMember(Name = "heroicKills")]
        public int HeroicKills;
        [DataMember(Name = "id")]
        public int Id;
    }
}
