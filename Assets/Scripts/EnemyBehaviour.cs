using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public DialogueBehaviour dialogue;
    public StatObject HPObject;
    public List<Action> actions = new List<Action>();
    public Stat HP;

    // Start is called before the first frame update
    void Start()
    {
        HP = HPObject.stat;
        StartCoroutine(Act());
    }

    private IEnumerator Act()
    {
        while(HP > 0)
        {
            int i = Random.Range(0, actions.Count - 1);
            Action action = actions[i];

            yield return action.Perform(gameObject, dialogue);
        }

        //Die animation
        dialogue.Display("Judgement died violently.");
    }
}
