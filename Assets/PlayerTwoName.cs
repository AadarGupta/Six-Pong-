using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTwoName : MonoBehaviour {

    public static string playerTwoNameStr;


    public Text playerTwo;

	// Use this for initialization
	void Start () {
        playerTwo.text = playerTwoNameStr;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
