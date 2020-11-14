using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Item RequiredItem { get; set; } 
        public Quest AvailableQuest { get; set; }
        public Monster MonsterInside { get; set; }
        public Location North { get; set; }
        public Location South { get; set; }
        public Location East { get; set; }
        public Location West { get; set; }

        public Location(int id, string name, string description, Item requiredItem = null, Quest availableQuest = null, Monster monsterInside = null)
        {
            ID = id;
            Name = name;
            Description = description;
            RequiredItem = requiredItem;
            AvailableQuest = availableQuest;
            MonsterInside = monsterInside;
        }
    }
}
