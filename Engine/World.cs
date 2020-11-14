using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Location> Locations = new List<Location>();

        public const int ITEM_ID_LONG_SWORD = 1;
        public const int ITEM_ID_MACE = 2;
        public const int ITEM_ID_HAND_AXE = 3;
        public const int ITEM_ID_HEALING_POTION = 4;
        public const int ITEM_ID_ADVENTURER_PASS = 5;
        public const int ITEM_ID_RAT_TAIL = 6;
        public const int ITEM_ID_PIECE_OF_FUR = 7;
        public const int ITEM_ID_SNAKE_SKIN = 8;
        public const int ITEM_ID_SNAKE_FANG = 9;
        public const int ITEM_ID_SPIDER_FANG = 10;
        public const int ITEM_ID_SPIDER_SILK = 11;
        public const int ITEM_ID_SPIDER_SKIN = 12;
        public const int ITEM_ID_WOLF_TOOTH = 13;
        public const int ITEM_ID_WOLF_SKIN = 14;
        public const int ITEM_ID_STONE_AMULET = 15;
        public const int ITEM_ID_ANCIENT_SYMBOL = 16;

        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_SMALL_SPIDER = 3;
        public const int MONSTER_ID_GIANT_SPIDER = 4;
        public const int MONSTER_ID_BIG_WOLF = 5;
        public const int MONSTER_ID_STONE_GOLEM = 6;

        public const int QUEST_ID_CLEAR_SEWERS = 1;
        public const int QUEST_ID_CLEAR_CLAY_CANYON = 2;
        public const int QUEST_ID_CLEAR_SCARY_FOREST = 3;
        public const int QUEST_ID_CLEAR_STONE_TEMPLE = 4;

        public const int LOCATION_ID_HOUSE = 1;
        public const int LOCATION_ID_TOWN_CENTER = 2;
        public const int LOCATION_ID_BLACKSMITH_HOUSE = 3;
        public const int LOCATION_ID_ALCHEMIST_TOWER = 4;
        public const int LOCATION_ID_BARRACKS = 5;
        public const int LOCATION_ID_STONE_TEMPLE = 6;
        public const int LOCATION_ID_SCARY_FOREST = 7;
        public const int LOCATION_ID_CLAY_CANYON = 8;
        public const int LOCATION_ID_CROSSROAD = 9;
        public const int LOCATION_ID_SPIDER_CAVE = 10;
        public const int LOCATION_ID_LAKE = 11;

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_LONG_SWORD, "Longsword", "Longswords", 1, 10));
            Items.Add(new Weapon(ITEM_ID_MACE, "Mace", "Maces", 1, 8));
            Items.Add(new Weapon(ITEM_ID_HAND_AXE, "Hand axe", "Hand axes", 3, 12));
            Items.Add(new HealingPotion(ITEM_ID_HEALING_POTION, "Healing potion", "Healing potions", 50));
            Items.Add(new Item(ITEM_ID_ADVENTURER_PASS, "Adventurer pass", "Adventurer passes"));
            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat tail", "Rat tails"));
            Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Fur piece", "Fur pieces"));
            Items.Add(new Item(ITEM_ID_SNAKE_SKIN, "Snake skin", "Snake skins"));
            Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake fang", "Snake fangs"));
            Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider fang", "Spider fangs"));
            Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider silk", "Spider silks"));
            Items.Add(new Item(ITEM_ID_SPIDER_SKIN, "Spider skin", "Spider skins"));
            Items.Add(new Item(ITEM_ID_WOLF_SKIN, "Wolf skin", "Wolf skins"));
            Items.Add(new Item(ITEM_ID_WOLF_TOOTH, "Wolf tooth", "Wolf teeth"));
            Items.Add(new Item(ITEM_ID_STONE_AMULET, "Stone amulet", "Stone amulets"));
            Items.Add(new Item(ITEM_ID_ANCIENT_SYMBOL, "Ancient symbol", "Ancient symbols"));
        }
        private static void PopulateMonsters()
        {
            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 2, 5, 10, 5, 20, 20);
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 80, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 85, true));

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 1, 10, 10, 25, 40, 40);
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 70, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_SKIN), 75, true));

            Monster smallSpider = new Monster(MONSTER_ID_SMALL_SPIDER, "Small spider", 3, 15, 35, 50, 80, 80);
            smallSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 85, true));
            smallSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SKIN), 30, false));

            Monster giantSpider = new Monster(MONSTER_ID_SMALL_SPIDER, "Giant spider", 5, 25, 50, 70, 100, 100);
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 85, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SKIN), 30, false));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 10, false));

            Monster bigWolf = new Monster(MONSTER_ID_BIG_WOLF, "Big wolf", 15, 45, 50, 100, 220, 220);
            bigWolf.LootTable.Add(new LootItem(ItemByID(ITEM_ID_WOLF_SKIN), 35, true));
            bigWolf.LootTable.Add(new LootItem(ItemByID(ITEM_ID_WOLF_TOOTH), 20, false));

            Monster stoneGolem = new Monster(MONSTER_ID_STONE_GOLEM, "Stone Golem", 30, 70, 250, 300, 400, 400);
            stoneGolem.LootTable.Add(new LootItem(ItemByID(ITEM_ID_STONE_AMULET), 30, false));
            stoneGolem.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ANCIENT_SYMBOL), 10, false));

            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(smallSpider);
            Monsters.Add(giantSpider);
            Monsters.Add(bigWolf);
            Monsters.Add(stoneGolem);
        }

        private static void PopulateQuests()
        {
            Quest clearSewers =
                new Quest(
                    QUEST_ID_CLEAR_SEWERS,
                    "Clear the Sewers.",
                    "Kill rats in the Sewers and bring back 3 rat tails. You will receive a healing potion and 10 gold pieces.", 20, 10);

            clearSewers.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 3));

            clearSewers.ItemReward = ItemByID(ITEM_ID_HEALING_POTION);

            Quest clearClayCanyon = new Quest(QUEST_ID_CLEAR_CLAY_CANYON,
                    "Clear the Clay Canyon.",
                    "Kill snakes in the farmer's field and bring back 3 snake fangs. You will receive an adventurer's pass and 20 gold pieces.", 40, 50);

            clearClayCanyon.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SNAKE_FANG), 3));

            clearClayCanyon.ItemReward = ItemByID(ITEM_ID_ADVENTURER_PASS);

            Quest clearScaryForest = new Quest(QUEST_ID_CLEAR_SCARY_FOREST,
                    "Clear the Scary Forest",
                    "Go to the Scary Forest, kill wolves and bring back: 10 wolf skins. You will receive an adventurer's pass and 100 gold pieces.", 100, 100);

            clearScaryForest.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_WOLF_SKIN), 10));

            clearScaryForest.ItemReward = ItemByID(ITEM_ID_ADVENTURER_PASS);
            clearScaryForest.ItemReward = ItemByID(ITEM_ID_HEALING_POTION);

            Quest clearStoneTemple = new Quest(QUEST_ID_CLEAR_STONE_TEMPLE,
                    "Clear the area of the Stone Temple",
                    "Kill golems in the Stone Temple and bring back 5 stone amulets. You will receive an adventurer's pass and 200 gold pieces.", 150, 200);

            clearStoneTemple.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_STONE_AMULET), 5));

            clearStoneTemple.ItemReward = ItemByID(ITEM_ID_ADVENTURER_PASS);
            clearStoneTemple.ItemReward = ItemByID(ITEM_ID_HEALING_POTION);

            Quests.Add(clearSewers);
            Quests.Add(clearClayCanyon);
            Quests.Add(clearScaryForest);
            Quests.Add(clearStoneTemple);
        }
        private static void PopulateLocations()
        {
        }

            public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }
        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }
        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }

            return null;
        }
        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }
    }
}
