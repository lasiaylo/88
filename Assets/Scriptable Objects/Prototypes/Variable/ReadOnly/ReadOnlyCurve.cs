using UnityEngine;

[CreateAssetMenu(fileName = "ReadOnlyCurve", menuName = "Variables/ReadOnly/Curve")]
public class ReadOnlyCurve : ReadOnlyVariable<AnimationCurve>
{
    //public void Awake()
    //{
    //    _val = AnimationCurve.Linear(0.0f, 0.0f, 1.0f, 1.0f);
    //}
}
