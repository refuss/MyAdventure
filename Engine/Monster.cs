using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : Creature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }
        public int ExpReward { get; set; }
        public int GoldReward { get; set; }
        public List<LootItem> LootTable { get; set; }
        public Monster(int id, string name, int minDamage, int maxDamage, int expReward, int goldReward, int currentHitPoints, int maximumHitPoints): 
            base (currentHitPoints,maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            ExpReward = expReward;
            GoldReward = goldReward;
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
            LootTable = new List<LootItem>();
        }
    }
}
