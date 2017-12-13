using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour{

    public float speed = 5f;

    // Use this for initialization
    void Start()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody2D>().velocity = new Vector3(speed * x, speed * y, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x >= 18.8f)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
        }

        if (this.transform.position.x >= -18.8f)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
        }
    }
}