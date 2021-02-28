using System.Collections;
using Events;
using JetBrains.Annotations;
using UnityEngine;

public class CountingAttack : Action
{
    [SerializeField] private float Power, WaitTime = default;
    [SerializeField] private Stat stamina = default;
    [SerializeField, NotNull] private StringEvent speechEvent;

    public override IEnumerator Perform(params GameObject[] target)
    {
        // TODO: Should be for loop
        speechEvent.Raise("3..");
        stamina.SetValue(25);

        yield return Wait();

        speechEvent.Raise("2..");
        stamina.SetValue(50);

        yield return Wait();

        speechEvent.Raise("1..");
        stamina.SetValue(75);

        yield return Wait();

        speechEvent.Raise("");
        target[0].GetComponent<PlayerHealth>().Damage(Power);
        stamina.SetValue(100);
        yield return Wait();
    }

    public WaitForSeconds Wait()
    {
        return new WaitForSeconds(WaitTime);
    }

}
