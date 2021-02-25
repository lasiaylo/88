using UnityEngine;
using System.Collections;

public class PlayerHealth : Health
{
    public PlayerGuard guard;
    public AudioClip damagedAudio;
    public AudioClip guardedAudio;

    private AudioSource audioSource;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public override void Damage(float damage)
    {
        if (guard.Status != GuardStatus.Guarding)
        {
            // TODO: Send Player Damage Event
            // TODO: Screen Shake
            // TODO: Noise
            audioSource.PlayOneShot(damagedAudio);
            HP.MinusOverTime(damage);

        } else
        {

            // Send Player Guard Event
            audioSource.PlayOneShot(guardedAudio);
            Debug.Log("WHOAH! A block!");
        }
    }

    public override void Die()
    {
        // TODO: Display Death Message
        // TODO: Reset Game
    }


    // Update is called once per frame
    void Update()
    {

    }

}
