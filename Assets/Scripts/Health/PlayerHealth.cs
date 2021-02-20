using UnityEngine;
using System.Collections;

public class PlayerHealth : Health
{
    public PlayerGuard guard;
    public AudioSource damageSound;
    public AudioSource damageGuardedSound;

    public override void Damage(float damage)
    {
        if (guard.Status == GuardStatus.Guarding)
        {
            // Send Player Guard Event
            damageGuardedSound.Play();
            Debug.Log("WHOAH! A block!");
        } else
        {
            // TODO: Send Player Damage Event
            // TODO: Screen Shake
            // TODO: Noise
            damageSound.Play();
            HP.MinusOverTime(damage);
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
