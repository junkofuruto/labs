using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze
{
    public class Maze
    {
        uint levelsCount, addedOstacles, basicScore;

        public uint BasicScore       
        {
            get { return basicScore; }
            set { basicScore = value; }
        }
        public uint LevelsCount      
        {
            get { return levelsCount; }
            set { levelsCount = value; }
        }
        public uint AddedObstacles   
        {
            get { return addedOstacles; }
            set { addedOstacles = value; }
        }

        public virtual uint GetLevelObstacles()
        {
            return LevelsCount * AddedObstacles;
        }
        public virtual uint GetLevelScore()
        {
            return BasicScore * LevelsCount * AddedObstacles;
        }
        public string GetDifficulty()
        {
            if (AddedObstacles < 3)
            {
                return "Не ощущается";
            }
            else if (AddedObstacles >= 3 & AddedObstacles < 5)
            {
                return "Легче легкого";
            }
            else if (AddedObstacles >= 5 & AddedObstacles < 7)
            {
                return "Нормально";
            }
            else if (AddedObstacles >= 7 & AddedObstacles < 10)
            {
                return "Кошмар";
            }
            else
            {
                return "Ультра кошмар";
            }
        }
    }
    public class ItemMaze : Maze
    {
        uint addedItems;
        public uint AddedItems
        {
            get { return addedItems; }
            set { addedItems = value; }
        }

        public override uint GetLevelObstacles()
        {
            return LevelsCount * AddedItems;
        }
        public override uint GetLevelScore()
        {
            return BasicScore * AddedItems * LevelsCount;
        }
    }
    public class MonsterMaze : Maze
    {
        uint addedMonsters;
        public uint AddedMonsters
        {
            get { return addedMonsters; }
            set { addedMonsters = value; }
        }

        public override uint GetLevelObstacles()
        {
            return LevelsCount * AddedMonsters;
        }
        public override uint GetLevelScore()
        {
            return BasicScore * AddedMonsters * LevelsCount;
        }
    }
}
