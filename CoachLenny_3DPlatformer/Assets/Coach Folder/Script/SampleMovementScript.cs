using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleMovementScript : MonoBehaviour
{
    //Variable that controls our speed
    public float speed;
    //Variable that controls our jump
    public float jump;

    //This variable will be for touching the ground
    public bool IsGrounded;

    //This variable is for our game physics
    public Rigidbody physics;

    // Update is called once per frame
    void Update()
    {
        /// Challenge
        /// Create key inputs for all four directions
        /// Use the example code above to recreate the movement and remember: 
        /// Positive is: right, up, and forward
        /// Negavtive is: left, down, and backwards
        
        //If I press the W key
        if (Input.GetKey(KeyCode.W))
        {
            //Move my player forward at a speed of 10f by the second
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        //If I press the S key
        if (Input.GetKey(KeyCode.S))
        {
            //Move my player backward at a speed of 10f by the second
            transform.Translate(Vector3.forward * -1 * speed * Time.deltaTime);
        }

        //If I press the D key
        if (Input.GetKey(KeyCode.D))
        {
            //Move my player right at a speed of 10f by the second
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        //If I press the A key
        if (Input.GetKey(KeyCode.A))
        {
            //Move my player left at a speed of 10f by the second
            transform.Translate(Vector3.right * -1 * speed * Time.deltaTime);
        }

        ///Challenge 2
        ///Create a if statement when pressed DOWN the player jumps!
        ///use Input.GetKeyDown()
        ///use a RigidBody variable to use AddForce() method

        //If I press the space key and i am grounded
        if (Input.GetKey(KeyCode.Space) & IsGrounded)
        {
            //Create a local Vector3 variable and put the jump variable in the Y column
            Vector3 JumpForce = new Vector3(physics.velocity.x, jump, physics.velocity.z);

            //Create a Force that causes the player to jump
            physics.AddForce(JumpForce, ForceMode.Force);
        }

    }

    //This method checks the moment the player has touched another collider
    private void OnCollisionEnter(Collision other)
    {
        IsGrounded = true;
    }

    //This method checks the moment the player has stopped touched another collider
    private void OnCollisionExit(Collision collision)
    {
        IsGrounded = false;
    }


}
