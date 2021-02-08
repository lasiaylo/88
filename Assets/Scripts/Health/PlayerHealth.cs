using UnityEngine;
using System.Collections;

public class PlayerHealth : Health
{
    public PlayerGuard guard;

    public override void Damage(float damage)
    {
        if (guard.Status == GuardStatus.Guarding)
        {
            // Send Player Guard Event
            Debug.Log("WHOAH! A block!");
        } else
        {
            // TODO: Send Player Damage Event
            // TODO: Screen Shake
            // TODO: Noise
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
