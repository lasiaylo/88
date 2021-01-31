using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public Stat HP;
    public DialogueBehaviour dialogue;
    public List<IAction> actions = new List<IAction>();

    // Start is called before the first frame update
    void Start()
    {
        actions.Add(new CountAttack());
        StartCoroutine(Act());
    }

    private IEnumerator Act()
    {
        while(HP > 0)
        {
            int i = Random.Range(0, actions.Count - 1);
            IAction action = actions[i];
            HP.Minus(1);
            yield return action.Perform(gameObject, dialogue);
        }

        //Die animation
        dialogue.Display("Judgement died violently.");
    }
}
