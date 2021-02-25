using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextSpawner : MonoBehaviour
{
    public GameObject TextPrefab;
    public float MinXVelocity;
    public float MaxXVelocity;
    public float MinYVelocity;
    public float MaxYVelocity;

    public void Spawn(string msg)
    {
        // Should use an object pool
        GameObject text = Instantiate(TextPrefab, transform);
        Rigidbody2D rigidBody = text.GetComponent<Rigidbody2D>();
        TextMeshPro textMesh = text.GetComponent<TextMeshPro>();
        textMesh.SetText(msg);
        rigidBody.velocity = new Vector2(
            Random.Range(MinXVelocity, MaxXVelocity),
            Random.Range(MinYVelocity, MaxYVelocity)
        );
    }

    public void Spawn(int msg)
    {
        Spawn(msg.ToString());
    }
}
