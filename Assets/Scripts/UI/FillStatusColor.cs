using UnityEngine;
using UnityEngine.UI;

public class FillStatusColor : MonoBehaviour
{
    [SerializeField] private Stat stamina;
    public Color FullColor;
    private Color OriginalColor;
    private Image image;

    public void Start()
    {
        image = GetComponent<Image>();
        OriginalColor = image.color;
    }

    public void Update()
    {
        image.color = stamina.IsFull() ? FullColor : OriginalColor;
    }
}
