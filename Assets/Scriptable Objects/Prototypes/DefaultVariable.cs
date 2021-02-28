using UnityEngine;

namespace ScriptableObjects.Prototypes
{
    public abstract class DefaultVariable<T> : DefaultScriptableObject
    {
        [SerializeField] private T _defaultVal = default;
        public T Val;

        public override void Reset()
        {
            Val = _defaultVal;
        }

    }
}