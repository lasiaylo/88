using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Player Attack", menuName = "Actions/Player Attack", order = 0)]

public class PlayerAttack : Action
{
    private const int POWER = 10;

    public override IEnumerator Perform(GameObject gameObject, DialogueBehaviour dialogue)
    {
        Stat hp = gameObject.GetComponent<EnemyBehaviour>().HP; //inefficient to grab this every time. should cache.
        hp.MinusOverTime(POWER);
        dialogue.Display("You attack Judgement!"); // really need central place
        yield break;
    }

}
