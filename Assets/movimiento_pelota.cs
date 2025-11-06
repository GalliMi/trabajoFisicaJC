using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_pelota : MonoBehaviour
{
    public float fuerza = 10f;          
    private Rigidbody rb;
    bool inicio = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            inicio = true;

        }

        if (inicio == true)
        {
            rb.AddForce(transform.right * fuerza, ForceMode.Force);
        }
    }
}
