using UnityEngine;


// THIS IS GETTING REALLY BLOATED :(
// SHOULD REALLY REFACTOR

[CreateAssetMenu(fileName = "Stat", menuName = "Stat", order = 0)]
public class Stat : ScriptableObject, ISerializationCallbackReceiver
{
    [SerializeField] private float _Stat;
    [SerializeField] private float _Tick;
    [SerializeField] private int _TicksPerSecond;
    public Target Target;
    public bool ResetOnDeserialize = true;

    public void OnEnable()
    {
        Target = new Target(_Stat, _Tick, _TicksPerSecond);
    }

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

    public void Reset()
    {
        SetValue(_Stat);
    }

    public void ResetOverTime(float? tick = null, float? ticksPerSecond = null)
    {
        SetValueOverTime(_Stat, tick, ticksPerSecond);
    }

    public void OnAfterDeserialize()
    {
        if (ResetOnDeserialize)
        {
            Reset();
        }
    }

    public void OnBeforeSerialize() { }
}
