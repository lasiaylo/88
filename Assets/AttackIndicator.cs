using UnityEngine;
using Util;
using DG.Tweening;

public class AttackIndicator : MonoBehaviour
{

    // TODO: THIS IS GOING TO BE BAD CODE
    public ReadOnlyCurve curve;
    private readonly float edge = 2.75f;
    private readonly Toggle goLeft = new Toggle();

    public void Move(AnimationCurve curve, float duration)
    {
        float target = goLeft.Flip() ? edge : -edge;
        transform.DOMoveX(target, duration).SetEase(curve);
    }
}
