using UnityEngine;

namespace Events
{
    [CreateAssetMenu(fileName = "BoolEvent", menuName = "Events/Bool", order = 0)]
    public class BoolEvent : GameEvent<bool> { }
}