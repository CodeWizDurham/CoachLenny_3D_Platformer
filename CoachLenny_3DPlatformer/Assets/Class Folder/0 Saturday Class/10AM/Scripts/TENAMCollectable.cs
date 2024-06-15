using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TENAMCollectable : MonoBehaviour
{
    //This variable is used to keep track of points
    public int PointValue;

    //This method checks the moment the player has touched another collider
    private void OnCollisionEnter(Collision collision)
    {
        //If i touch an object with the player tag
        if (collision.gameObject.tag == "Player")
        {
            //Destroy this gameobject
            
            //Create a print method that prints out the Point Value to the console
            
        }
    }
}
