using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Giocatore.domain
{
    public class Player
    {
        string _name;
        int _level;
        int _experience;
        int _health;
        int _maxHealth;
        bool _isAlive;
        int _gold;

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
                _experience = value;
            }
        }
        public int Health { get; private set; }
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
                } else if(value < 100){
                    throw new ArgumentOutOfRangeException("MaxHealth must be at least 100.");
                    value = 100;
                } else
                {
                    _maxHealth = value;
                }
            }
        }
        public bool IsAlive { get; private set; }

        public int Gold
        {
            get
            {
                return _gold;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Gold cannot be negative.");
                }
            }
        }
        public Player(string name, int level, int experience, int health, int maxHealth, bool isAlive, int gold)
        {
            Name = name;
            Level = level;
            Experience = experience;
            Health = health;
            MaxHealth = maxHealth;
            IsAlive = isAlive;
            Gold = gold;
        }

        public void AddExperience(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Experience amount cannot be negative.");
            }
            Experience += amount;
            if (Experience % 100 == 0)
            {
            } else if (Experience % 100 > 0)
            {
                while (Experience >= 100)
                {
                    Experience -= 100;
                    Level++;
                }
            }
        }

        public void ResetExperience()
        {
            Experience = 0;
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0)
            {
                throw new ArgumentOutOfRangeException("Damage cannot be negative.");
            }
            Health -= damage;
            if (Health <= 0)
            {
                IsAlive = false;
                Health = 0;
            }
        }
        public void AddHealth(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Heal amount cannot be negative.");
            }
            Health += amount;
            if (Health > MaxHealth)
            {
                Health = MaxHealth;
            }
        }

        public void AddGold(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Gold amount cannot be negative.");
            }
            Gold += amount;
        }

        public void ResetHealth()
        {
            Health = MaxHealth;
        }
    }
}
