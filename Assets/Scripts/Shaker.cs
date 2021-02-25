using UnityEngine;

public class Shaker : MonoBehaviour
{
    public float Intensity;
    public float Decay;
    public float XMultiplier = 1;
    public float YMultiplier = 1;

    private Vector3 originPos;
    private float currentIntensity;
    
    public void Awake()
    {
        originPos = transform.position;
    }

    public void Update()
    {
        if (currentIntensity > 0)
        {
            // Would like to choose how many frames to change position
            Vector2 disp = Random.insideUnitCircle * currentIntensity;
            transform.position = originPos + new Vector3(
                disp.x * XMultiplier,
                disp.y * YMultiplier,
                0
            );
            currentIntensity -= Decay;
        }
    }

    public void Shake()
    {
        currentIntensity = Intensity;
    }
}
