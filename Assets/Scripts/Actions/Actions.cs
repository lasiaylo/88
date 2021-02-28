using UnityEngine;
using System.Collections.Generic;

public class Actions : MonoBehaviour
{
    public List<PlayerAction> ActionsList;
    [SerializeField] private TextDisplayer _Dialogue = default;
    [SerializeField] private GameObject _Target = default;

    private Stat _Stamina;
    private Dictionary<string, PlayerAction> _actionsDict;

    // Use this for initialization
    public void Start()
    {
        _Stamina = GetComponent<PlayerBehaviour>().Stamina;
        _actionsDict = new Dictionary<string, PlayerAction>();
        foreach (PlayerAction action in ActionsList)
        {
            //Should use Enum instead of strings?
            _actionsDict.Add(action.GetType().ToString(), action);
        }
    }

    public void Perform(string actionName)
    {
        PlayerAction action = _actionsDict[actionName];
        if (_Stamina.GetValue() == _Stamina.GetStat())
        {
            _Stamina.Minus(action.GetStaminaCost());
            _Stamina.ResetOverTime();
            Task.Get(action.Perform(_Target));
        }

        // TODO: Play unable to perform action animation
    }

}
