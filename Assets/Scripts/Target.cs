using UnityEngine;
using System.Collections;
using System;


// A float variable that constantly moves towards target value
[Serializable]
public class Target
{
    public float Val;
    public float TargetVal;
    public float Tick;
    public float TicksPerSecond;

    public Task task;

    public Target(float currentValue = 0, float tick = 0, float ticksPerSecond = 0)
    {
        Val = TargetVal = currentValue;
        Tick = tick;
        TicksPerSecond = ticksPerSecond;

        task = Task.Get(MoveTowards());
    }

    public void InstantSet(float val)
    {
        Val = TargetVal = val;
    }

    // TODO: Figure out custom ramp functions i.e. Linear, Exp, Square
    private IEnumerator MoveTowards()
    {
        float min = TargetVal < Val ? TargetVal : Val;
        float max = TargetVal < Val ? Val : TargetVal;
        while (true)
        {
            Val = Mathf.Clamp(Val += Tick, min, max);
            yield return new WaitForSeconds(1 / TicksPerSecond);
        }
    }
}
