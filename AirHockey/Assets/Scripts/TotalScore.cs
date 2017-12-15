using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour {

    public Text playerOneScoreText;
    public Text playerTwoScoreText;

    private float total1;
    private float total2;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        total1 = Score.tot1;
        playerOneScoreText.text = total1.ToString();

        total2 = Score.tot2;
        playerTwoScoreText.text = total2.ToString();
    }
}
