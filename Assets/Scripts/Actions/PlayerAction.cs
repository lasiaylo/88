using UnityEngine;

public abstract class PlayerAction : Action
{

    // Need a way to centralize information.
    // would like to eventually have this injected from xml
    [SerializeField] private float StaminaCost = default; //Deducting from Stamina should be done outside of this class

    public float GetStaminaCost() => StaminaCost;
    // Have Stamina as its own class that handles its own deductions
    // Stamina should stay down a bit before regening
    // Reward players for doing an action right when stamina recharges?
    //    Prevent spam by having timers - similar to teching
}
