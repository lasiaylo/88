using UnityEngine;
using System.Collections;

public class CountAttack : IAction
{
    public IEnumerator Perform(GameObject gameObject, DialogueBehaviour dialogue)
    {
        dialogue.Display("Judgement started counting");
        //yield return new WaitForSeconds(2f);
        //dialogue.Display("3...");
        //yield return new WaitForSeconds(2f);
        //dialogue.Display("2...");
        //yield return new WaitForSeconds(2f);
        //dialogue.Display("1...");
        //yield return new WaitForSeconds(2f);

        dialogue.Display("Judgement lunged forward!");

        EnemyBehaviour enemy = gameObject.GetComponent<EnemyBehaviour>();

        yield return enemy.HP.MinusOverTime(50, 1);
        enemy.HP.SetValue(0);
    }
}
