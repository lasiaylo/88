using System.Collections;
using Events;
using JetBrains.Annotations;
using UnityEngine;

public class CountingAttack : Action
{
    [SerializeField] private float Power, WaitTime = default;
    [SerializeField] private Stat stat = default;
    [SerializeField, NotNull] private StringEvent speechEvent;

    public override IEnumerator Perform(params GameObject[] target)
    {
        // TODO: Should be for loop
        speechEvent.Raise("3..");
        yield return Wait();

        speechEvent.Raise("2..");
        yield return Wait();

        speechEvent.Raise("1..");
        yield return Wait();

        target[0].GetComponent<PlayerHealth>().Damage(Power);

        speechEvent.Raise("");
        yield return Wait();
    }

    public WaitForSeconds Wait()
    {
        return new WaitForSeconds(WaitTime);
    }

}
