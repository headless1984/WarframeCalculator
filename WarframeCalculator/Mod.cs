using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeCalculator
{
    class Mod
    {
        public string Name { get; set; }

        public List<Effect> ttlEffect { get; set; }

        public int Cost { get; set; }

        public int maxLevel { get; set; }

        public int Level { get; set; }

    }
}
