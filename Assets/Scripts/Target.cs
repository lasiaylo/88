using UnityEngine;
using System.Collections;
using System;


// A float variable that constantly moves towards target value
[Serializable]
public class Target
{
    public float Val;
    [SerializeField] private float TargetVal;
    public float Tick;
    public float TicksPerSecond;

    private float min;
    private float max;
    private float tick;

    public Task task = null;

    public Target(float currentValue = 0, float tick = 0, float ticksPerSecond = 0)
    {
        Val = TargetVal = currentValue;
        Tick = tick;
        TicksPerSecond = ticksPerSecond;
    }

    public void InstantSet(float val)
    {
        Val= val;
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
