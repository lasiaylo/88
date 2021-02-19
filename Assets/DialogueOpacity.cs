using UnityEngine;
using UnityEngine.UI;

public class DialogueOpacity : MonoBehaviour
{
    public Stat Stamina;
    [Range(0, 1)]
    public float Opacity;
    public Image image;
    private Color tempColor;
    private Color originalColor;

    public void Start()
    {
        image = GetComponent<Image>();
        tempColor = image.color;
        originalColor = image.color;
        tempColor.a = Opacity;
    }

    void Update()
    {
        image.color = Stamina.GetValue() == Stamina.GetStat()
            ? originalColor
            : tempColor;
    }
}
