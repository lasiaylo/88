using UnityEngine;

public static class FloatExtensions
{
    public static bool IsZero(this float value)
    {
        return Mathf.Approximately(value, 0);
    }
}
