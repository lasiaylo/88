using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountingAttack : Action
{
    public float Power;
    public float WaitTime;
    [Range(0, 1)]
    public float Anticipation;

    public override IEnumerator Perform(GameObject gameObject, DialogueBehaviour dialogue)
    {
        dialogue.Display("3...");
        yield return Wait();

        dialogue.Display("2...");
        yield return Wait();

        dialogue.Display("1...");
        yield return Wait();
    }

    public WaitForSeconds Wait()
    {
        return new WaitForSeconds(WaitTime);
    }

}
