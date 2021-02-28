using UnityEngine;
using System.Collections;

public enum GuardStatus
{
    Guarding,
    NotGuarding,
}

public class PlayerGuard : PlayerAction
{
    public GuardStatus Status;
    public AudioClip guardAudio;
    [SerializeField] private float duration;

    public override IEnumerator Perform(GameObject[] target)
    {
        Status = GuardStatus.Guarding;
        //target[0].GetComponent<AudioSource>().PlayOneShot(guardAudio); // Should cache/ write caching utility

        yield return new WaitForSeconds(duration);

        Status = GuardStatus.NotGuarding;
    }

    public void OnAfterDeserialize()
    {
        Status = GuardStatus.NotGuarding;
    }

    public void OnBeforeSerialize() { }
}
