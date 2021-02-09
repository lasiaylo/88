using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectEffects : MonoBehaviour
{
    public float FadeRate;
    public float ScaleSpeed;
    private RectTransform RectTransform;
    private Image Image;
    private Vector3 originalScale;
    private Color originalColor;
    private Color tempColor;

    public void Start()
    {
        Image = GetComponent<Image>();
        RectTransform = GetComponent<RectTransform>();
        originalColor = Image.color;
        originalScale = RectTransform.localScale;
        tempColor = originalColor;
    }

    public void Update()
    {
        if (tempColor.a > 0)
        {
            Fade();
            Scale();
        }
    }

    public void Select()
    {
        if (tempColor.a == 0)
        {
            tempColor = originalColor;
            RectTransform.localScale = originalScale;
        }
    }

    private void Fade()
    {
        tempColor.a = Mathf.Clamp(tempColor.a - FadeRate, 0, 255);
        Image.color = tempColor;
    }

    private void Scale()
    {
        RectTransform.localScale *= ScaleSpeed;
    }
}
