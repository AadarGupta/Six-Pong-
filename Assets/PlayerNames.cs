using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerNames : MonoBehaviour {

    public InputField playerOneName;
    public InputField playerTwoName;
    public Button PlayButton;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void PlayGame()
    {
        PlayerOneName.playerOneNameStr = playerOneName.text + " Wins!";
        PlayerTwoName.playerTwoNameStr = playerTwoName.text + " Wins!";

        SceneManager.LoadScene(1);
    }
}
