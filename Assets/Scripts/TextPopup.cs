using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextPopup : MonoBehaviour
{
    private TextMeshPro _TextMesh;
    private Rigidbody2D _RigidBody;

    public void Awake()
    {
        _TextMesh = GetComponent<TextMeshPro>();
        _RigidBody = GetComponent<Rigidbody2D>();
        _RigidBody.velocity = new Vector2(5, 20);

    }

    public void Display(string msg)
    {
        _TextMesh.SetText(msg);
    }

    public void SetVelocity(Vector2 vector)
    {
        _RigidBody.velocity = vector;
    }

    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
