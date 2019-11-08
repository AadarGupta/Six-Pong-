using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOneName : MonoBehaviour {

    public static string playerOneNameStr;


    public Text playerOne;

	
    // Use this for initialization
	void Start () {
        playerOne.text = playerOneNameStr;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
