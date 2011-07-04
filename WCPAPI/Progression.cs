using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Progression : ICollection
    {
        [DataMember(Name = "raids")]
        public List<Raid> Raids;

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

    public class Raid
    {
        public string name;
        public int normal;
        public int heroic;
        public int id;
        public List<Boss> bosses;

        public override string ToString()
        {
            return String.Format("Name: {0}", name);
        }
    }

    public class Boss
    {
        public string name;
        public int normalKills;
        public int heroicKills;
        public int id;
    }
}
