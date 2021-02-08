using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Player Attack", menuName = "Actions/Player/Player Attack", order = 0)]

public class PlayerAttack : PlayerAction
{
    [SerializeField] private const int _Power = 10;

    public override IEnumerator Perform(GameObject gameObject, DialogueBehaviour dialogue)
    {
        Stat hp = gameObject.GetComponent<EnemyBehaviour>().HP; //inefficient to grab this every time. should cache.
        hp.MinusOverTime(_Power);
        //dialogue.Display("You attack Judgement!"); // really need central place
        yield break;
    }

}
