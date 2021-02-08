using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Count Attack", menuName = "Actions/Count Attack", order = 0)]
public class CountAttack : Action
{
    public override IEnumerator Perform(GameObject gameObject, DialogueBehaviour dialogue)
    {
        dialogue.Display("Judgement started counting");
        //dialogue.Display("3...");
        yield return new WaitForSeconds(2f);
        //dialogue.Display("2...");
        //yield return new WaitForSeconds(2f);
        //dialogue.Display("1...");
        //yield return new WaitForSeconds(2f);

        dialogue.Display("Judgement lunged forward!");

        EnemyBehaviour enemy = gameObject.GetComponent<EnemyBehaviour>();

        //yield return enemy.HP.MinusOverTime(50, 1);
    }
}
