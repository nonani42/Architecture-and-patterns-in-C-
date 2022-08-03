using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class Health
    {
        public float MaxHealth { get; private set; }

        public float CurrentHealth { get; private set; }

        public Health(float maxHp, float currentHp)
        {
            MaxHealth = maxHp;
            CurrentHealth = currentHp;
        }

        void ChangeCurrentHealth(float damage)
        {
            CurrentHealth -= damage;
        }

        void ChangeMaxHealth(float maxHp)
        {
            MaxHealth = maxHp;
        }
    }
}
