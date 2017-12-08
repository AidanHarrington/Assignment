using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int maxHits;

    public AudioClip myClip;

    public int numberOfHits;

    private Level_Manager myLevelManager;
    
    public static int breakableCount = 0;

    void HandleHits()
    {
        numberOfHits++;
        if (numberOfHits >= maxHits)
        {
            breakableCount--;
            AudioSource.PlayClipAtPoint(myClip,this.transform.position);
            print("Hello");
            Destroy(this.gameObject);
            myLevelManager.brickDestroy();
        }
    }

    private bool isBreakable = false;

    void OnCollisionEnter2D(Collision2D collision) {
        if (isBreakable)
        {
            HandleHits();
        }
    }

    void SimulateWin()
    {
        myLevelManager.LoadNextLevel();
    }
	
	void Start () {
        isBreakable = this.tag == ("Breakable");

        if (isBreakable)
        {
            breakableCount++;
            print (breakableCount);
        }

        myLevelManager = GameObject.FindObjectOfType<Level_Manager>();
        numberOfHits = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
