﻿using UnityEngine;

public abstract class Health : MonoBehaviour
{
    [SerializeField] protected Stat HP = default;
    [SerializeField] protected Stat Defense = default;

    public abstract void Damage(float damage);

    public void Heal(float heal)
    {
        HP.Add(heal);
    }

    public abstract void Die();

    // Should figure out a better name
    public void CheckHP()
    {
        if (HP.IsEmpty())
        {
            // Should send Death Event
            Die();
        }
    }

    public Stat GetHP() => HP;

    private float CalculateDamage(float damage)
    {
        return damage - Defense.GetStat();
    }
}
