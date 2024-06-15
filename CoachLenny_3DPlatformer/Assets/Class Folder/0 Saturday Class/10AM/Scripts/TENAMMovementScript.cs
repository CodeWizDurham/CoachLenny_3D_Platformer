using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TENAMMovementScript : MonoBehaviour
{
    //Variable that controls our speed
    public float speed;

    public float jump;

    //This variable will be for touching the ground
    public bool IsGrounded;

    //This variable is for our game physics
    public Rigidbody physics;

    // Update is called once per frame
    void Update()
    {
        //If I press the W key
        if (Input.GetKey(KeyCode.W))
        {
            //Move my player forward at a speed of 10f by the second
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        //If I press the S key
        //If I press the D key
        //If I press the A key

        /// Challenge 1
        /// Create key inputs for all four directions
        /// Use the example code above to recreate the movement and remember: 
        /// Positive is: right, up, and forward
        /// Negavtive is: left, down, and backwards
        

        ///Challenge 2
        ///Create a if statement when pressed DOWN the player jumps!
        ///use Input.GetKeyDown()
        ///use a RigidBody variable to use AddForce() method
        
        //If I press the Space Key and I am grounded


    }

    //This method checks the moment the player has touched another collider
    private void OnCollisionEnter(Collision collision)
    {
        //Is grounded is true
        IsGrounded = true;
    }

    //This method checks the moment the player has stopped touched another collider
    private void OnCollisionExit(Collision collision)
    {
        //Is grounded is false
        IsGrounded = false;
    }
}
