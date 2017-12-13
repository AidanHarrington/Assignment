using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue_Paddle : MonoBehaviour {

    public GameObject Paddle1;

	void Update () {

        float mouseY = (Input.mousePosition.y / Screen.height * 20f) - 10f;
        mouseY = Mathf.Clamp(mouseY, -8f, 8f);

        Vector3 paddlePosition = new Vector3(this.transform.position.x, mouseY, 0f);
        //print(mouseY);

        this.transform.position = paddlePosition;
    }
}
