using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// NEED TO REFACTOR. BAD BAD BAD.
public class DamageBar : MonoBehaviour
{
    public Stat Stat;

    private RectTransform rectTransform;

    public void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        rectTransform.localScale = new Vector3(Mathf.Clamp(Stat.Target.GetTargetVal() / Stat.GetStat(), 0, 1), rectTransform.localScale.y, rectTransform.localScale.z);
    }
}
