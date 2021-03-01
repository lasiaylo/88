using UnityEngine;
using System.Collections;
using System;

// A float variable that constantly moves towards target value
[Serializable]
public class Approacher
{
    public float Val;
    [SerializeField] private float TargetVal = default;
    public float Tick;
    public float TicksPerSecond;

    private float min;
    private float max;
    private float tick;

    private Task task = null;

    public void InstantSet(float val)
    {
        Val = val;
        TargetVal = val;
    }

    public void SetTargetVal(float val)
    {
        task = task ?? Task.Get(MoveTowards());
        TargetVal = val;
        min = TargetVal < Val ? TargetVal : Val;
        max = TargetVal < Val ? Val : TargetVal;
        tick = TargetVal < Val ? -Tick : Tick;
    }

    public float GetTargetVal() => TargetVal;

    // TODO: Figure out custom ramp functions i.e. Linear, Exp, Square
    private IEnumerator MoveTowards()
    {
        while (true)
        {
            Val = Mathf.Clamp(Val += tick, min, max);
            yield return new WaitForSeconds(1 / TicksPerSecond);
        }
    }
}
