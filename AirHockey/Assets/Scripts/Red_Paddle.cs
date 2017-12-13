using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red_Paddle : MonoBehaviour {

    private Rigidbody2D rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(0f, 20f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(0f, -20f);
        }
        else
        {
            rb.velocity = new Vector3(0f, 0f);
        }
    }
}