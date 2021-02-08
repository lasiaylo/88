using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    [SerializeField] private DialogueBehaviour dialogue;
    public override void Damage(float damage)
    {
        HP.Minus(damage);
    }

    public override void Die()
    {
        dialogue.Display("Judgement died violently!");
    }

}
