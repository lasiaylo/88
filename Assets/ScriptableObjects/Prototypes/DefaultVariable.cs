using UnityEngine;

namespace ScriptableObjects.Prototypes {
public abstract class DefaultVariable<T> : DefaultScriptableObject {
    [SerializeField] private T _defaultVal;
    public T Val;

    public override void ResetToDefault() {
        Val = _defaultVal;
    }

}
}