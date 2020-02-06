﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Combat
{
    public class Health : MonoBehaviour
    {
         
        [SerializeField] float healthPoints = 100f;

        private bool isDead;

        void Start()
        {
            isDead = false;
        }

        public bool IsDead() { return isDead; }
        public void TakeDamage(float damage)
        {
            healthPoints = Mathf.Max(healthPoints - damage, 0);
            print(healthPoints);
            if (healthPoints == 0)
            {
                Die();
            }
        }

        private void Die()
        {
            if (isDead) { return; }
            GetComponent<Animator>().SetTrigger("Die");
            isDead = true;
        }
    }
}

