using System.Collections;
using UnityEngine;

public abstract class Action : ScriptableObject
{
    public abstract IEnumerator Perform(params GameObject[] target);
}