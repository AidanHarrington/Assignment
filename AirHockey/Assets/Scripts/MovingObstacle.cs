using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour {

    public GameObject rightBat;
    public float speed = 5f;
    Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        float pos = (Input.mousePosition.y / Screen.height * 20f) - 10f;
        pos = Mathf.Clamp(pos, -8f, 8f);

        Vector3 ObstaclePos = new Vector3(rightBat.transform.position.x, pos * speed * Time.deltaTime, 0f);
        //print(mouseY);

        //rightBat.transform.position = paddlePosition;

        
    }
    
        
}
