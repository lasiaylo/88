using UnityEngine;

public enum Phase
{
    Start,
    Continue,
    End,
}

namespace ScriptableObjects.Prototypes.Variable
{
    [CreateAssetMenu(fileName = "Phase", menuName = "Variables/Default/PhaseVariable")]
    public class DefaultPhase : DefaultVariable<Phase>
    {
    }
}