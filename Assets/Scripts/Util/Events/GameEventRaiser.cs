using JetBrains.Annotations;
using UnityEngine;

namespace Events {
    public class GameEventRaiser<T> : MonoBehaviour {
        [SerializeField, NotNull] private GameEvent<T> gameEvent;
        public T value;
    }
}