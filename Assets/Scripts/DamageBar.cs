using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// NEED TO REFACTOR
public class DamageBar : MonoBehaviour
{
    public StatObject statObject;

    private Stat stat;
    private RectTransform rt;

    public void Start()
    {
        rt = GetComponent<RectTransform>();
        stat = statObject.stat;
    }

    // Update is called once per frame
    void Update()
    {
        rt.localScale = new Vector3(Mathf.Clamp(stat.Target / stat.GetStat(), 0, 1), rt.localScale.y, rt.localScale.z);
    }
}
