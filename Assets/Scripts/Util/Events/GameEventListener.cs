using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

namespace Events {
    public abstract class GameEventListener<T> : MonoBehaviour {
        [SerializeField, NotNull] private GameEvent<T> gameEvent;
        [SerializeField, NotNull] protected UnityEvent<T> response;

        public void OnEnable() {
            gameEvent.RegisterListener(this);
        }

        public void OnDisable() {
            gameEvent.UnregisterListener(this);
        }
        
        public void OnEventRaised(T val) {
            response.Invoke(val);
        }
    }

    //public class BoolEventListener : GameEventListener<bool> { }
}