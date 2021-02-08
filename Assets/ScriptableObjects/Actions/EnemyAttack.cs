using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Count Attack", menuName = "Actions/Count Attack", order = 0)]
public class EnemyAttack : Action
{
    private const float POWER = 33;
    private const float WAIT = 1.5f;
    public override IEnumerator Perform(GameObject gameObject, DialogueBehaviour dialogue)
    {
        dialogue.Display("Judgement started counting!");
        yield return Wait();

        dialogue.Display("3...");
        yield return Wait();

        dialogue.Display("2...");
        yield return Wait();

        dialogue.Display("1...");
        yield return Wait();

        dialogue.Display("Judgement lunged forward!");

        PlayerHealth player = gameObject.GetComponent<PlayerHealth>();
        player.Damage(POWER);

        yield return new WaitForSeconds(3f);

    }

    public WaitForSeconds Wait()
    {
        return new WaitForSeconds(WAIT);
    }
}
