using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatLeftController : MonoBehaviour {

    // Reference the rigidbody 2d as rb
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        
        // Define rb as the rigidbody 2d component of the current game object
        rb = this.GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {

        // Checks if the player presses W
        if(Input.GetKey(KeyCode.W)){
            // Moves the left bat in the upwards direction
            rb.velocity = new Vector2(0f, 25f);
        }

        // Checks if the player presses S
        else if (Input.GetKey(KeyCode.S)){
            // Moves the left bat in the downwards direction
            rb.velocity = new Vector2(0f, -25f);

        }

        else{
            rb.velocity = new Vector2(0f, 0f);
        }

	}

}
