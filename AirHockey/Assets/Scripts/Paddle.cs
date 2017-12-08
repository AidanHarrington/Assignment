using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
	
	void Update () {

        float mousePosInBlocks = (Input.mousePosition.y / Screen.width * 54f) - 27F;
        Vector3 paddlePosition = new Vector3(this.transform.position.x, 1f, 0);
        
        paddlePosition.y = Mathf.Clamp(mousePosInBlocks, -6.5f, 6.5f);
        this.transform.position = paddlePosition;
        //print(mousePosInBlocks);
    }
}
