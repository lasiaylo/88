using UnityEngine;
using Events;

// Maybe get rid of EnemyHealth altogether and let it all be handled by IntEvents
public class EnemyHealth : Health
{
    [SerializeField] private TextDisplayer dialogue;
    public IntEvent damageEvent;

    public override void Damage(float damage)
    {
        HP.Minus(damage);
        damageEvent.Raise((int)damage);
    }

    public override void Die()
    {
        dialogue.Display("Judgement died violently!");
    }
}
