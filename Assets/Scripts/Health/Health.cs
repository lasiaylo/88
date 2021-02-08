using UnityEngine;
using System.Collections;

public abstract class Health : MonoBehaviour
{
    [SerializeField] protected Stat HP;
    [SerializeField] protected Stat Defense;

    public abstract void Damage(float damage);

    public void Heal(float heal)
    {
        HP.Add(heal);
    }

    public abstract void Die();

    // Should figure out a better name
    public void CheckHP()
    {
        if (HP.GetValue() == 0)
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
