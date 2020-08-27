using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    [Tooltip("Mass in kilograms(kg)")]
    //[Range(0.1f, 10000f)]
    public float mass = 50;

    [Tooltip("Whether the gameobject is static or attracted to other bodies.")]
    public bool isStatic = false;

    public Vector2 velocity;

    public Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
}
