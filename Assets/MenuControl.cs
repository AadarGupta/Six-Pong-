﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour {

    public Button PlayButton;
    public Button QuitButton;
    public Button InstructionButton;

	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {



	}

    public void PlayGame (){
        SceneManager.LoadScene(5);
    }

    public void QuitGame(){
                // save any game data here
        #if UNITY_EDITOR
                // Application.Quit() does not work in the editor so
                // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                 Application.Quit();
        #endif
    }

    public void Intructions(){
        SceneManager.LoadScene(4);
    }

}
