using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class Ball : MonoBehaviour
{
    public float maxSpeed = 20f;


    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        // Limitar velocidad máxima
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }
}
