using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOff : MonoBehaviour
{
    //Much like the Start() and Update() methods, OnTriggerEnter2D is a special Unity method that is Called
    //by Unity automatically at a specific point - in this case, when something enters the Trigger attached
    // to this GameObject
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If the GameObject that has collided with our trigger is tagged with CleanUp...
        if (collision.gameObject.tag == "BulletOff")
        {
            //Then we use this method to destroy it
            Destroy(collision.gameObject);
        }
    }
}