
namespace WowCharacterInfo
{
    public enum RepStanding
    {
        Hated = 0,
        Hostile = 1,
        Unfriendly = 2,
        Neutral = 3,
        Friendly = 4,
        Honored = 5,
        Revered = 6,
        Exalted = 7,
    }

    public class Reputation
    {
        public int id;
        public string name;
        public RepStanding standing;
        public int value;
        public int max;
    }
}
