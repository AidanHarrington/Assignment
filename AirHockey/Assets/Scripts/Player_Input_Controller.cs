using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input_Controller : MonoBehaviour {

	public GameObject leftBat;
    public GameObject rightBat;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

		if (Input.GetKey (KeyCode.W)) {

			leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 18f, 0f);
		}

		else if (Input.GetKey (KeyCode.S)) {

			leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -18f, 0f);
		}

        float mouseY = (Input.mousePosition.y / Screen.height * 20f) - 10f;
        mouseY = Mathf.Clamp(mouseY, -8f, 8f);

        Vector3 paddlePosition = new Vector3(rightBat.transform.position.x, mouseY, 0f);
        //print(mouseY);

        rightBat.transform.position = paddlePosition;

    }
}
