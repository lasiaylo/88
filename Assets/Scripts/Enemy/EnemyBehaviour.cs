using System.Collections;
using System.Collections.Generic;
using Events;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public EnemyHealth Health;
    public GameObject targetObject;
    public StringEvent promptEvent;

    public List<Action> actions = new List<Action>();
    void Start()
    {
        Health = GetComponent<EnemyHealth>();
        Task.Get(Act());
    }

    private IEnumerator Act()
    {
        while (Health.GetHP().GetValue() > 0)
        {
            int i = Random.Range(0, actions.Count - 1);
            Action action = actions[i];

            yield return action.Perform(targetObject);
        }

        //TODO: Die animation
        promptEvent.Raise("Judgement died violently.");
    }
}
