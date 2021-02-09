using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    [SerializeField] private DialogueBehaviour dialogue;
    private TextSpawner spawner;
    private Shaker shaker;

    public void Awake()
    {
        spawner = GetComponent<TextSpawner>();
        shaker = GetComponent<Shaker>();
    }

    public override void Damage(float damage)
    {
        HP.Minus(damage);
        string msg = ((int)damage).ToString();
        spawner.Spawn(msg);
        shaker.Shake();

        // Shake sprite
        // spawn hp text

        // Ideall should be event
    }

    public override void Die()
    {
        dialogue.Display("Judgement died violently!");
    }
}
