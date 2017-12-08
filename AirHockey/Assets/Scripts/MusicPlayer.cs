using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer myMusicPlayer = null;

    void Awake()
    {
        if (myMusicPlayer != null)
        {
            Debug.Log("Destroying object " + this.gameObject.GetInstanceID().ToString());
            Destroy(this.gameObject);
        }
        else
        {
            myMusicPlayer = this;
            GameObject.DontDestroyOnLoad(this.gameObject);
        }
    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
