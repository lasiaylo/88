using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class SpeechBubbleBehaviour : MonoBehaviour
{
    private CanvasGroup canvasGroup;

    public void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void ToggleVisible(string msg)
    {
        canvasGroup.alpha = string.IsNullOrEmpty(msg) ? 0 : 1;

    }
}
