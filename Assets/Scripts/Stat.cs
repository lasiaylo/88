using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Stat
{
    [SerializeField] private float _Stat;
    [SerializeField] private float _Value;
    [SerializeField] private float _Tick;
    [SerializeField] private int _TicksPerSecond;
    public float Delta { get; private set; }

    public static implicit operator float(Stat stat) => stat._Value;
    public static implicit operator bool(Stat stat) => stat._Value > 0;

    public void SetStat(float target)
    {
        _Stat = target;
    }

    public float GetStat() => _Stat;

    public void SetValue(float target) => _Value = target;

    public IEnumerator SetValueOverTime(float target, float tick = 0, float ticksPerSecond = 0)
    {
        float oldValue = _Value;
        tick = tick.IsZero() ? _Tick : tick;
        tick = target < oldValue ? -Mathf.Abs(tick) : Mathf.Abs(tick);
        ticksPerSecond = ticksPerSecond.IsZero() ? _TicksPerSecond : ticksPerSecond;
        float min = target < oldValue ? target : oldValue;
        float max = target < oldValue ? oldValue : target;
        while (oldValue != target)
        {
            _Value = Mathf.Clamp(oldValue += tick, min, max);
            Delta = Mathf.Abs(target - _Value);
            yield return new WaitForSeconds(1 / ticksPerSecond);
        }
    }

    public float GetValue() => _Value;

    public void Add(float delta) => SetValue(_Value + delta);

    public IEnumerator AddOverTime(float delta, float tick = 0, float ticksPerSecond = 0)
    {
        yield return SetValueOverTime(_Value + delta, tick, ticksPerSecond);
        //trigger add event
    }

    public void Minus(float delta) => SetValue(_Value - delta);

    public IEnumerator MinusOverTime(float delta, float tick = 0, float ticksPerSecond = 0)
    {
        yield return SetValueOverTime(_Value - delta, tick, ticksPerSecond);
        // trigger minus event
    }

    public void Reset()
    {
        SetValue(_Stat);
    }

    public IEnumerator ResetOverTime(float tick = 0, float ticksPerSecond = 0)
    {
        yield return SetValueOverTime(_Stat, tick, ticksPerSecond);
    }

//TODO: Add/Minus with a ramp instead of linear

}
