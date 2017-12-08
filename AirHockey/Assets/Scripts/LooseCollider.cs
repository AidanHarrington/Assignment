using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseCollider : MonoBehaviour {

    private Level_Manager myLevelManager;

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collider with " + collision.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        print("Triggered by " + collision.gameObject.name);
        myLevelManager.LoadLevel("Win");
    }

    // Use this for initialization
    void Start () {
        myLevelManager = GameObject.FindObjectOfType<Level_Manager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
