using UnityEngine;

public class AttackBar : MonoBehaviour
{
    [SerializeField] private Stat stamina;

    public void Update()
    {
        if (stamina.IsFull())
        {

        }
    }
}
