using System.Collections;
using UnityEngine;

/// Taken from Ken Rockot
/// And modified further by Wildan Mubarok <http://wellosoft.wordpress.com>
public enum InterpolationType
{
    /// Standard linear interpolation
    Linear = 0,
    /// Smooth fade interpolation
    SmoothStep = 1,
    /// Smoother fade interpolation than SmoothStep
    SmootherStep = 2,
    /// Sine interpolation, smoothing at the end
    Sinerp = 3,
    /// Cosine interpolation, smoothing at the start
    Coserp = 4,
    /// Extreme bend towards end, low speed at end
    Square = 5,
    /// Extreme bend toward start, high speed at end
    Quadratic = 6,
    /// Stronger bending than Quadratic
    Cubic = 7,
    /// Spherical interpolation, vertical speed at start
    CircularStart = 8,
    /// Spherical interpolation, vertical speed at end
    CircularEnd = 9,
    /// Pure Random interpolation
    Random = 10,
    /// Random interpolation with linear constraining at 0..1
    RandomConstrained = 11
}

// TODO: UNfinished, might not need
public static class Interpolator
{
    public static IEnumerator Interpolate(
        float start,
        float end,
        float duration,
        InterpolationType interpolType = InterpolationType.Linear,
        bool inverted = false
    )
    {
        float endTime = Time.time + duration;
        while (endTime > Time.time)
        {
            float t = 1 - ((endTime - Time.time) / duration);
            switch (interpolType)
            {
                case InterpolationType.Linear: break;
                case InterpolationType.SmoothStep: t = t * t * (3f - 2f * t); break;
                case InterpolationType.SmootherStep: t = t * t * t * (t * (6f * t - 15f) + 10f); break;
                case InterpolationType.Sinerp: t = Mathf.Sin(t * Mathf.PI / 2f); break;
                case InterpolationType.Coserp: t = 1 - Mathf.Cos(t * Mathf.PI / 2f); break;
                case InterpolationType.Square: t = Mathf.Sqrt(t); break;
                case InterpolationType.Quadratic: t = t * t; break;
                case InterpolationType.Cubic: t = t * t * t; break;
                case InterpolationType.CircularStart: t = Mathf.Sqrt(2 * t + t * t); break;
                case InterpolationType.CircularEnd: t = 1 - Mathf.Sqrt(1 - t * t); break;
                case InterpolationType.Random: t = Random.value; break;
                case InterpolationType.RandomConstrained: t = Mathf.Max(Random.value, t); break;
            }
            if (inverted)
                t = 1 - t;
            yield return Mathf.Lerp(start, end, t);
        }
    }
}
