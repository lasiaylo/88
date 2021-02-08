using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatBar : MonoBehaviour
{

    public Stat Stat;

    private RectTransform rt;

    // Start is called before the first frame update
    public void Start()
    {
        rt = GetComponent<RectTransform>();
    }
    // Update is called once per frame
    public void Update()
    {
        rt.localScale = new Vector3(Mathf.Clamp(Stat.GetValue() / Stat.GetStat(), 0, 1), rt.localScale.y, rt.localScale.z);
    }
}
