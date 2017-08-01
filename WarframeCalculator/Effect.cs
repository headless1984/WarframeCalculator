using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeCalculator
{
    public enum EffectType
    { Duration,
    Strength,
    Range,
    Efficiency,}

    class Effect
    {
        public EffectType Type { get; set; }
        public float bonusMalus { get; set; }
        public float increament { get; set; }
    }
}
