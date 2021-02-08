using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class OldStat
{
    [SerializeField] private float _Stat;
    [SerializeField] private float _Tick;
    [SerializeField] private int _TicksPerSecond;
    public Target Target = new Target();
    public bool ResetOnDeserialize = true;

    public void SetStat(float val) => _Stat = val;

    public float GetStat() => _Stat;

    public void SetValue(float val)
    {
        Target.InstantSet(val);
    }

    public void SetValueOverTime(float target, float? tick = null, float? ticksPerSecond = null)
    {
        Target.TicksPerSecond = ticksPerSecond ?? _TicksPerSecond;
        Target.Tick = tick ?? _Tick;
        Target.TargetVal = target;
    }

    public float GetValue() => Target.Val;

    public void Add(float delta) => SetValue(GetValue() + delta);

    public void AddOverTime(float delta, float? tick = null, float? ticksPerSecond = null)
    {
        SetValueOverTime(GetValue() + delta, tick, ticksPerSecond);
        //trigger add event
    }

    public void Minus(float delta) => SetValue(GetValue() - delta);

    public void MinusOverTime(float delta, float tick = 0, float ticksPerSecond = 0)
    {
        SetValueOverTime(GetValue() - delta, tick, ticksPerSecond);
        // trigger minus event
    }

    public void Reset()
    {
        SetValue(_Stat);
        Target.InstantSet(_Stat);
    }

    public void ResetOverTime(float tick = 0, float ticksPerSecond = 0)
    {
        SetValueOverTime(_Stat, tick, ticksPerSecond);
    }
}
