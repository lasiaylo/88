using UnityEngine;
using System.Collections;


public enum GuardStatus
{
    Guarding,
    NotGuarding,
}

[CreateAssetMenu(fileName = "Player Guard", menuName = "Actions/Player/Player Guard", order = 0)]
public class PlayerGuard : PlayerAction
{
    public GuardStatus Status;
    [SerializeField] private float _Duration;

    public override IEnumerator Perform(GameObject gameObject, DialogueBehaviour dialogue)
    {
        Debug.Log("WHOAH, NIce Guards");
        Status = GuardStatus.Guarding;

        yield return new WaitForSeconds(_Duration);

        Status = GuardStatus.NotGuarding;
    }

    public void OnAfterDeserialize()
    {
        Status = GuardStatus.NotGuarding;
    }

    public void OnBeforeSerialize() { }
}
