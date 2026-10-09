using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class Player
    {
        string _name;
        int _level;
        int _experience;
        int _health;
        int _maxHealth;
        bool _isAlive;
        int gold;

        public string Name { get; set; }
        public int Level
        {
            get
            {
                return _level;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Level must be at least 1.");
                }
            }
        }
        public int Experience
        {
            get
            {
                return _experience;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Experience cannot be negative.");
                }
            }
        }
        public int Health
        {
            get
            {
                return _health;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Health cannot be negative.");
                }
            }
        }
        public int MaxHealth
        {
            get
            {
                return _maxHealth;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("MaxHealth must be at least 1.");
                }
            }
        }
        public bool IsAlive { get; private set; }
        public int Gold
        {
            get
            {
                return gold;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Gold cannot be negative.");
                }
            }
        }
    }
}
}
