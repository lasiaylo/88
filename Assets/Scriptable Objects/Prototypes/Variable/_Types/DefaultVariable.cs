using UnityEngine;

namespace ScriptableObjects.Prototypes
{
    public abstract class DefaultVariable<T> : DefaultScriptableObject
    {
        [SerializeField] protected T _defaultVal = default;
        public T Val;

        public override void Reset()
        {
            Val = _defaultVal;
        }

    }
}