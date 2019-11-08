using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountScore : MonoBehaviour {

    public Text ScoreBoard;
    public GameObject Ball;

    private int batLeftScore = 0;
    private int batRightScore = 0;

	// Use this for initialization
	void Start () {
        Ball = GameObject.Find("ball");
	}
	
	// Update is called once per frame
	void Update () {


        if (Ball.transform.position.x >= 25){
            if (Ball.transform.position.y >= 8 || Ball.transform.position.y <= -8){
                batLeftScore++;
                Ball.transform.position = new Vector2(0f, 0f);
            }

            else
            {
                batLeftScore += 6;
                Ball.transform.position = new Vector2(0f, 0f);
            }

            }


        else if (Ball.transform.position.x <= -25)
        {
            if (Ball.transform.position.y >= 8 || Ball.transform.position.y <= -8)
            {
                batRightScore++;
                Ball.transform.position = new Vector2(0f, 0f);
            }

            else
            {
                batRightScore += 6;
                Ball.transform.position = new Vector2(0f, 0f);
            }
        }

        if (batLeftScore >= 25){
            SceneManager.LoadScene(2);
        }
        if (batRightScore >= 25){
            SceneManager.LoadScene(3);
        }

        ScoreBoard.text = batLeftScore.ToString() + " - " + batRightScore.ToString();


		
	}
}
