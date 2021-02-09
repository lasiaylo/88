using System;
using UnityEngine;

public static class VectorExtensions
{
    private static readonly float _tolerance = 0.001f;

    #region Move Towards One Axis

    public static Vector3 MoveTowardsX(this Vector3 val, float target, float maxDistanceDelta)
    {
        return Vector3.MoveTowards(val, new Vector3(target, val.y, val.z), maxDistanceDelta);
    }

    public static Vector3 MoveTowardsY(this Vector3 val, float target, float maxDistanceDelta)
    {
        return Vector3.MoveTowards(val, new Vector3(val.x, target, val.z), maxDistanceDelta);
    }

    public static Vector3 MoveTowardsZ(this Vector3 val, float target, float maxDistanceDelta)
    {
        return Vector3.MoveTowards(val, new Vector3(val.x, val.y, target), maxDistanceDelta);
    }

    public static Vector2 MoveTowardsX(this Vector2 val, float target, float maxDistanceDelta)
    {
        return Vector2.MoveTowards(val, new Vector2(target, val.y), maxDistanceDelta);
    }

    public static Vector2 MoveTowardsY(this Vector2 val, float target, float maxDistanceDelta)
    {
        return Vector2.MoveTowards(val, new Vector2(val.x, target), maxDistanceDelta);
    }

    #endregion

    #region Move Towards Plane

    public static Vector3 MoveTowardsXy(this Vector3 val, Vector3 target, float maxDistanceDelta)
    {
        return Vector3.MoveTowards(val, new Vector3(target.x, target.y, val.z), maxDistanceDelta);
    }

    public static Vector3 MoveTowardsXz(this Vector3 val, Vector3 target, float maxDistanceDelta)
    {
        return Vector3.MoveTowards(val, new Vector3(target.x, val.y, target.z), maxDistanceDelta);
    }

    public static Vector3 MoveTowardsYz(this Vector3 val, Vector3 target, float maxDistanceDelta)
    {
        return Vector3.MoveTowards(val, new Vector3(val.x, target.y, target.y), maxDistanceDelta);
    }

    #endregion

    #region Is Zero

    public static bool IsZero(this Vector3 val)
    {
        return Math.Abs(val.magnitude) < _tolerance;
    }

    public static bool IsZero(this Vector2 val)
    {
        return Math.Abs(val.magnitude) < _tolerance;
    }

    #endregion

    #region Get Plane

    public static Vector2 GetXy(this Vector3 val)
    {
        return new Vector2(val.x, val.y);
    }

    public static Vector2 GetXz(this Vector3 val)
    {
        return new Vector2(val.x, val.z);
    }

    public static Vector2 GetYz(this Vector3 val)
    {
        return new Vector2(val.y, val.z);
    }

    #endregion
}
