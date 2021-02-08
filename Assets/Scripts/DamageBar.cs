using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// NEED TO REFACTOR
public class DamageBar : MonoBehaviour
{
    public Stat Stat;

    private RectTransform rt;

    public void Start()
    {
        rt = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        rt.localScale = new Vector3(Mathf.Clamp(Stat.Target.TargetVal / Stat.GetStat(), 0, 1), rt.localScale.y, rt.localScale.z);
    }
}
