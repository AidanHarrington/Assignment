using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour {

	Rigidbody rb;


	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();

		StartCoroutine (Pause ());


	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.x < -25f) {

			transform.position = Vector3.zero;
			rb.velocity = Vector3.zero;

			Score.instance.GivePlayerTwoAPoint();


			StartCoroutine (Pause ());
		}

		if (transform.position.x > 25f) {

			transform.position = Vector3.zero;
			rb.velocity = Vector3.zero;

			Score.instance.GivePlayerOneAPoint();

			StartCoroutine (Pause ());
		}


	}

	IEnumerator Pause () {

		yield return new WaitForSeconds (2.5f);

		LaunchBall ();
	}

	void LaunchBall () {

		transform.position = Vector3.zero;

		int xDirection = Random.Range(0, 2);

		int yDirection = Random.Range(0, 3);


		Vector3 launchDirection = new Vector3 ();
        
		if (xDirection == 0) {

			launchDirection.x = -20f;
		}
		if (xDirection == 1) {

			launchDirection.x = 20f;
		}

		if (yDirection == 0) {

			launchDirection.y = -20f;
		}
		if (yDirection == 1) {

			launchDirection.y = 20f;
		}
		if (yDirection == 2) {

			launchDirection.y = 0f;
		}
        
		rb.velocity = launchDirection;
	}
    
	void OnCollisionEnter (Collision hit) {

		if (hit.gameObject.name == "TopBounds") {

			float speedInXDirection = 0f;

			if (rb.velocity.x > 0f)
				speedInXDirection = 20f;

			if (rb.velocity.x < 0f)
				speedInXDirection = -20f;

			rb.velocity = new Vector3 (speedInXDirection, -20f, 0f);
		}

		if (hit.gameObject.name == "BottomBounds") {
			
			float speedInXDirection = 0f;

			if (rb.velocity.x > 0f)
				speedInXDirection = 20f;

			if (rb.velocity.x < 0f)
				speedInXDirection = -20f;

			rb.velocity = new Vector3 (speedInXDirection, 20f, 0f);
		}

        if (hit.gameObject.name == "Obstacle")
        {

            float speedInXDirection = 0f;

            if (rb.velocity.x > 0f)
                speedInXDirection = 20f;

            if (rb.velocity.x < 0f)
                speedInXDirection = -20f;

            rb.velocity = new Vector3(speedInXDirection, -20f, 0f);
        }

        if (hit.gameObject.name == "Obstacle (2)")
        {

            float speedInXDirection = 0f;

            if (rb.velocity.x > 0f)
                speedInXDirection = 20f;

            if (rb.velocity.x < 0f)
                speedInXDirection = -20f;

            rb.velocity = new Vector3(speedInXDirection, -20f, 0f);
        }
        
        if (hit.gameObject.name == "Left_Bat") {

			rb.velocity = new Vector3 (20f, 0f, 0f);

			if (transform.position.y - hit.gameObject.transform.position.y < -1) {

				rb.velocity = new Vector3 (20f, -20f, 0f);
			}
			
			if (transform.position.y - hit.gameObject.transform.position.y > 1) {

				rb.velocity = new Vector3 (20f, 20f, 0f);
			}
		}
		if (hit.gameObject.name == "Right_Bat") {

			rb.velocity = new Vector3 (-20f, 0f, 0f);
            
			if (transform.position.y - hit.gameObject.transform.position.y < -1) {

				rb.velocity = new Vector3 (-20f, -20f, 0f);
			}
			
			if (transform.position.y - hit.gameObject.transform.position.y > 1) {

				rb.velocity = new Vector3 (-20f, 20f, 0f);
			}
		}

	}

}
