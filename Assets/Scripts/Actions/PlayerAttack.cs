using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Player Attack", menuName = "Actions/Player Attack", order = 0)]

public class PlayerAttack : Action
{
    private EnemyBehaviour enemy;
    private const int POWER = 10;

    public override IEnumerator Perform(GameObject gameObject, DialogueBehaviour dialogue)
    {
        enemy = gameObject.GetComponent<EnemyBehaviour>(); //inefficient to grab this every time. should cache.
        enemy.HP.Minus(POWER);
        dialogue.Display("You attack Judgement!"); // really need central place
        yield break;
    }
}
