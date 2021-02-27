using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Player Attack", menuName = "Actions/Player/Player Attack", order = 0)]

public class PlayerAttack : PlayerAction
{
    [SerializeField] private const int _Power = 10;

    public override IEnumerator Perform(GameObject[] target)
    {
        Health health = target[0].GetComponent<EnemyHealth>(); //inefficient to grab this every time. should cache.
        health.Damage(_Power);
        yield break;
    }

}
