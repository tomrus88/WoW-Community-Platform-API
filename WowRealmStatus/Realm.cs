using System.Collections.Generic;

namespace WowRealmStatus
{
    class Realm
    {
        #pragma warning disable 0649
        public string type;
        public string population;
        public bool queue;
        public bool status;
        public string name;
        public string slug;
        #pragma warning restore 0649

        public string[] ToStringArray()
        {
            return new string[]
            {
                name,
                slug,
                type,
                population,
                queue.ToString(),
                status.ToString()
            };
        }
    }
}
