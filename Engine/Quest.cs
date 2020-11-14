using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int GoldReward { get; set; }
        public int ExpReward { get; set; }
        public Item ItemReward{ get; set; }
        public List<QuestCompletionItem> QuestCompletionItems { get; set; }

        public Quest (int id, string title, string description, int goldReward, int expReward, Item itemReward)
        {
            ID = id;
            Title = title;
            Description = description;
            GoldReward = goldReward;
            ExpReward = expReward;
            ItemReward = itemReward;
            QuestCompletionItems = new List<QuestCompletionItem>();
        }
    }
}
