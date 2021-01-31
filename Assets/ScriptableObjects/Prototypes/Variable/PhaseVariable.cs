using UnityEngine;

public enum Phase
{
    Start,
    Continue,
    End,
}

namespace ScriptableObjects.Prototypes.Variable
{
    [CreateAssetMenu(fileName = "Phase", menuName = "Variables/PhaseVariable", order = 0)]
    public class PhaseVariable : DefaultVariable<Phase>
    {
    }
}