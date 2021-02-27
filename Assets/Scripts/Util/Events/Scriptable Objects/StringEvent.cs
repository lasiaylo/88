using UnityEngine;

namespace Events
{
    [CreateAssetMenu(fileName = "StringEvent", menuName = "Events/String", order = 0)]
    public class StringEvent : GameEvent<string> { }
}