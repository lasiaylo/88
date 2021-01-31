using System;
using System.Collections;
using UnityEngine;

public abstract class PlayerAction : MonoBehaviour
{
    private readonly IAction _Action;
    private readonly DialogueBehaviour _Dialogue;
    private readonly Stat _Stamina;
    private float _StaminaCost;

    public PlayerAction(GameObject player)
    {
        _Stamina = player.GetComponent<PlayerBehaviour>().Stamina;
        _Dialogue = player.GetComponent<PlayerBehaviour>().Dialogue;
    }

    public void Perform()
    {
        // Have Stamina as its own class that handles its own deductions
        // Stamina should stay down a bit before regening
        // Reward players for doing an action right when stamina recharges?
        //    Prevent spam by having timers - similar to teching
        _Stamina.Minus(_StaminaCost);
        StartCoroutine(_Stamina.ResetOverTime());
        StartCoroutine(_Action.Perform(gameObject, _Dialogue));
    }
}
