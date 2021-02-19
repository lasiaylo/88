﻿using UnityEngine;
using UnityEngine.UI;

public class DamageBarColor : MonoBehaviour
{
    public PlayerGuard guard;
    public Color tempColor;

    private GuardStatus status;
    private Image image;
    //TODO: Refactor Image Color changing
    private Color originalColor;
    

    void Start()
    {
        image = GetComponent<Image>();
        originalColor = image.color;
    }

    void Update()
    {
        image.color = guard.Status == GuardStatus.Guarding
            ? tempColor
            : originalColor;
    }
}
