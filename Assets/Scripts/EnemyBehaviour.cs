using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public DialogueBehaviour dialogue;
    public EnemyHealth Health;
    public GameObject targetObject;
    public List<Action> actions = new List<Action>();
    // Start is called before the first frame update
    void Start()
    {
        Health = GetComponent<EnemyHealth>();
        Task.Get(Act());
    }

    private IEnumerator Act()
    {
        while(Health.GetHP().GetValue() > 0)
        {
            int i = Random.Range(0, actions.Count - 1);
            Action action = actions[i];

            yield return action.Perform(targetObject, dialogue);
        }

        //Die animation
        dialogue.Display("Judgement died violently.");
    }
}
