using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    float randomX, randomY;

    private Paddle myPaddle;

    private Vector3 paddleToBallVector;

    bool hasStarted = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        randomX = Random.Range(0f, 0.2f);
        randomY = Random.Range(0f, 0.2f);
        Vector2 tweak = new Vector2(randomX,randomY);
        if (hasStarted)
        {
            this.GetComponent<AudioSource>().Play();
            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }
    }

    // Use this for initialization
    void Start () {

        myPaddle = GameObject.FindObjectOfType<Paddle>();
        paddleToBallVector = this.transform.position - myPaddle.transform.position;
        
	}
	
	// Update is called once per frame
	void Update () {

        if (!hasStarted)
        {
            this.transform.position = myPaddle.transform.position + paddleToBallVector;
            
            // left mouse click
            if (Input.GetMouseButtonDown(0))
            {
                hasStarted = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            }
        }

	}
}
