using System.Collections;
using UnityEngine;

public abstract class Action : ScriptableObject
{
    public abstract IEnumerator Perform(GameObject gameObject, DialogueBehaviour dialogue);
}
