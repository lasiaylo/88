using System;
using System.Collections;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{

    // Need a way to centralize information.
    // would like to eventually have this injected from xml
    [SerializeField] private Action _Action;
    [SerializeField] private float StaminaCost; //Deducting from Stamina should be done outside of this class
    private DialogueBehaviour _Dialogue;
    private Stat _Stamina;
    private GameObject _Target; //Should be list

    public void Start()
    {
        _Stamina = GetComponent<PlayerBehaviour>().Stamina;
        _Dialogue = GetComponent<PlayerBehaviour>().Dialogue;
        _Target = GameObject.Find("Enemy");
    }

    public void Perform()
    {
        // Have Stamina as its own class that handles its own deductions
        // Stamina should stay down a bit before regening
        // Reward players for doing an action right when stamina recharges?
        //    Prevent spam by having timers - similar to teching
        Debug.Log("WHOAHHH");
        _Stamina.Minus(StaminaCost);
        StartCoroutine(_Stamina.ResetOverTime());
        StartCoroutine(_Action.Perform(_Target, _Dialogue));
    }
}
