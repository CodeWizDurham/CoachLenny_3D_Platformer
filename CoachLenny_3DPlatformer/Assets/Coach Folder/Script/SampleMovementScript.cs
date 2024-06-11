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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //3d
        //if i press w
        if (Input.GetKey(KeyCode.W))
        {
            //ove my player forward
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward * -1 * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.forward * -1 * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space) & isGrounded)
        {
            //Player Jump
            Vector3 JumpForce = new Vector3(physics.velocity.x, jump, physics.velocity.z);
            physics.AddForce(JumpForce,ForceMode.Force);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        isGrounded = true;

        if (other.gameObject.tag == "ground")
        {

        }
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
