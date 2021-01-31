using System.Collections;
using UnityEngine;

public interface IAction
{
    IEnumerator Perform(GameObject gameObject, DialogueBehaviour dialogue);
}
