using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBricks : MonoBehaviour {

    public List<GameObject> ListOfBricks = new List<GameObject>();

	void Start () {
        //gets all GameObjects from Resources folder and adds them to ListOfBricks
        ListOfBricks.AddRange(Resources.LoadAll<GameObject>(""));

        /*foreach(GameObject go in ListOfBricks)
        {
            print("Brick: " + go.name);
        }*/

        Vector3 pos = new Vector3(-5f,3f,0);

        for (int row = 1; row <= 6; row++)
        {
            for (int i = 1; i < 11; i++)
            {
                int Rand = (int)Random.Range(0f, ListOfBricks.Count);
                GameObject myGameObject = ListOfBricks[Rand];

                Instantiate(myGameObject, pos, Quaternion.identity);

                pos.x += 1f;
            }
            pos.x = -5f;
            pos.y -= 0.3f;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
