using System.Collections.Generic;

namespace HailNumber
{
    public class HailNumber
    {
        public long Value { get; set; }
        public List<long> Hops { get; set; }

        public HailNumber(long initialValue)
        {
            Hops = new List<long> {initialValue};
        }
    }
}
