using System;
using System.Collections.Generic;
using System.Linq;

namespace WarframeCalculator
{
    class ComboCalculator
    {
        private List<List<T>> GetCombination<T>(List<T> list)
        {
            List<List<T>> result = new List<List<T>>();

            double count = Math.Pow(2, list.Count);

            for (int i = 1; i <= count - 1; i++)
            {
                string str = Convert.ToString(i, 2).PadLeft(list.Count, '0');
                for(int j=0; j<str.Length;j++)
                {
                    result.Add(new List<T>());
                    if(str[j]=='1')
                    {
                        result.Last().Add(list[j]);
                    }
                }
            }
           return result.Where(x => x.Count <= 8).ToList();
        }
        private List<List<Mod>> GenerateAllLevel(List<Mod> list)
        {
            List<Mod> completeList = new List<Mod>();
            list.ForEach(mod =>
            {
                for(int i = 0; i <= mod.maxLevel; i++)
                {
                    List<Effect> calcEffect = new List<Effect>();

                    for(int j = 0; j < mod.ttlEffect.Count();j++)
                    {
                        calcEffect.Add(new Effect()
                        {
                            Type = mod.ttlEffect[j].Type,
                            bonusMalus = mod.ttlEffect[j].bonusMalus + (mod.ttlEffect[j].increament * i)
                        });
                    }

                    completeList.Add(new Mod()
                    {
                        Name = mod.Name,
                        Cost = mod.Cost+i,
                        Level = i,
                        ttlEffect = calcEffect                        
                    });
                }
            });

            return GetCombination<Mod>(completeList);
        }
    }
}
