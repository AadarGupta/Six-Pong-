using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatRightController : MonoBehaviour {

    // Reference the rigidbody 2d as rb
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {

        // Define rb as the rigidbody 2d component of the current game object
        rb = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        // Checks if the player presses up arrow
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // Moves the right bat in the upwards direction
            rb.velocity = new Vector2(0f, 25f);
        }

        // Checks if the player presses down arrow
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            // Moves the right bat in the downwards direction
            rb.velocity = new Vector2(0f, -25f);

        }

        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }

    }

}
