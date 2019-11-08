using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    // Reference the rigidbody 2d as rb
    private Rigidbody2D rb;

    public GameObject Ball;

	// Use this for initialization
	void Start () {
        // Define rb as the rigidbody 2d component of the current game object
        rb = this.GetComponent<Rigidbody2D>();

        // Flip a coin to determine the xDirection
        int xDirection = Random.Range(0, 2);

        // Flip a coin to determine the yDirection
        int yDirection = Random.Range(0, 3);

        // Randomizes the direction of the 
        Vector2 launchDirection = new Vector2();

        // Checks the results of the coin tosses and evaluates the initial velocity
        if (xDirection == 0){
            launchDirection.x = 12f;
        }
        if (xDirection == 1){
            launchDirection.x = -12f;
        }
        if (yDirection == 0)
        {
            launchDirection.y = 10f;
        }
        if (yDirection == 1)
        {
            launchDirection.y = -10f;
        }
        if (yDirection == 2){
            launchDirection.y = 0f;
        }
        if (Mathf.Abs(launchDirection.x) < 5f){
            launchDirection.x = 10f;
        }
        if (Mathf.Abs(launchDirection.x) > 12f && Mathf.Abs(launchDirection.y) > 10f){
            launchDirection.x = -6f;
            launchDirection.y = 5f;
        }
        // Gives the ball an initial velocity
        rb.velocity = launchDirection;

	}

    // Update is called once per frame
    void Update()
    {

        if (Ball.transform.position.x >= 15)
        {
            float pausetime = Time.time + 5;
            while (Time.time < pausetime)
            {
                rb.velocity = new Vector2(0, 0);
            }
        }


        else if (Ball.transform.position.x <= -15)
        {
            
        }

    }

    


	

}
