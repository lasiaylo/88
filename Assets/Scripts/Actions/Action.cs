using System.Collections;
using UnityEngine;

public abstract class Action : MonoBehaviour
{
    public abstract IEnumerator Perform(params GameObject[] target);
}