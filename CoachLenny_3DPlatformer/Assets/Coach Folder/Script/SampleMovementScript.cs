using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleMovementScript : MonoBehaviour
{
    //This variable is for our speed
    public float speed;

    public float jump;

    public Rigidbody physics;

    //This variable checks if were on the ground
    public bool isGrounded;

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
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }

        //If I press the S key
        if (Input.GetKey(KeyCode.S))
        {
            //Move my player backward at a speed of 10f by the second
            transform.Translate(transform.forward * -1 * speed * Time.deltaTime);
        }

        //If I press the D key
        if (Input.GetKey(KeyCode.D))
        {
            //Move my player right at a speed of 10f by the second
            transform.Translate(transform.right * speed * Time.deltaTime);
        }

        //If I press the A key
        if (Input.GetKey(KeyCode.A))
        {
            //Move my player left at a speed of 10f by the second
            transform.Translate(transform.right * -1 * speed * Time.deltaTime);
        }

        ///Challenge 2
        ///Create a if statement when pressed DOWN the player jumps!
        ///use Input.GetKeyDown()
        ///use a RigidBody variable to use AddForce() method

        //If I press the space key and i am grounded
        if (Input.GetKey(KeyCode.Space) & isGrounded)
        {
            //Create a local Vector3 variable and put the jump variable in the Y column
            Vector3 JumpForce = new Vector3(physics.velocity.x, jump, physics.velocity.z);

            //Create a Force that causes the player to jump
            physics.AddForce(JumpForce, ForceMode.Force);
        }

    }

    //When player collides with an object
    private void OnCollisionEnter(Collision other)
    {
        isGrounded = true;
    }

    //When player leaves an object
    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }


}
