using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatBar : MonoBehaviour
{

    public StatObject StatObject;

    private Stat stat;
    private RectTransform rt;

    // Start is called before the first frame update
    public void Start()
    {
        rt = GetComponent<RectTransform>();
        stat = StatObject.stat;
    }
    // Update is called once per frame
    public void Update()
    {
        rt.localScale = new Vector3(Mathf.Clamp(stat.GetValue() / stat.GetStat(), 0, 1), rt.localScale.y, rt.localScale.z);
    }
}
