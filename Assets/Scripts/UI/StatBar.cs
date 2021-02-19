using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatBar : MonoBehaviour
{

    public Stat Stat;

    private RectTransform rectTransform;

    // Start is called before the first frame update
    public void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    // Update is called once per frame
    public void Update()
    {
        rectTransform.localScale = new Vector3(Mathf.Clamp(Stat.GetValue() / Stat.GetStat(), 0, 1), rectTransform.localScale.y, rectTransform.localScale.z);
    }
}
