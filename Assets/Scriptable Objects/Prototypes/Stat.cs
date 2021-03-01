using ScriptableObjects.Prototypes;
using UnityEngine;


public enum FillStatus
{
    Empty,
    Partway,
    Full,
}

// THIS IS GETTING REALLY BLOATED :(
// SHOULD REALLY REFACTOR
[CreateAssetMenu(fileName = "Stat", menuName = "Stat", order = 0)]
public class Stat : DefaultScriptableObject
{
    public float _Stat = default;
    public Approacher Target;
    public bool ResetOnDeserialize = true;

    public void SetStat(float val) => _Stat = val;

    public float GetStat() => _Stat;

    public void SetValue(float val)
    {
        Target.InstantSet(val);
    }

    public void SetValueOverTime(float target, float? tick = null, float? ticksPerSecond = null)
    {
        Target.SetTargetVal(target);
    }

    public float GetValue() => Target.Val;

    public void Add(float delta) => SetValue(GetValue() + delta);

    public void AddOverTime(float delta, float? tick = null, float? ticksPerSecond = null)
    {
        SetValueOverTime(Target.GetTargetVal() + delta, tick, ticksPerSecond);
        //trigger add event
    }

    public void Minus(float delta) => SetValue(GetValue() - delta);

    public void MinusOverTime(float delta, float? tick = null, float? ticksPerSecond = null)
    {
        SetValueOverTime(Target.GetTargetVal() - delta, tick, ticksPerSecond);
        // trigger minus event
    }

    public override void Reset()
    {
        SetValue(_Stat);
    }

    public void ResetOverTime(float? tick = null, float? ticksPerSecond = null)
    {
        SetValueOverTime(_Stat, tick, ticksPerSecond);
    }

    public float GetFillRatio()
    {
        return GetValue() / GetStat();
    }


    // Can probably refactor to separate Fill class
    // And set up events
    public FillStatus GetStatus()
    {
        switch (GetFillRatio())
        {
            case 0:
                return FillStatus.Empty;
            case 1:
                return FillStatus.Full;
            default:
                return FillStatus.Partway;
        }
    }

    public bool IsFull()
    {
        return GetStatus() == FillStatus.Full;
    }

    public bool IsEmpty()
    {
        return GetStatus() == FillStatus.Empty;
    }
}
