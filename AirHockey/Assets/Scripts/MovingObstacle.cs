using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour {

    private Vector3 posA;
    private Vector3 posB;
    private Vector3 nextpos;

    [SerializeField]
    private float speed;

    [SerializeField]
    private Transform childTransform;

    [SerializeField]
    private Transform transformB;

    // Use this for initialization
    void Start () {
        posA = childTransform.localPosition;
        posB = transformB.localPosition;
        nextpos = posB;
    }
	
	// Update is called once per frame
	void Update () {
        Move();
    }

    private void Move()
    {
        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, nextpos, speed * Time.deltaTime);
        ChangeDestination();        
    }

    private void ChangeDestination()
    {
        nextpos = nextpos != posA ? posA : posB;
    }
}
