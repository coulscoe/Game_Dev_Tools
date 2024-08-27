using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pickupscript : MonoBehaviour
{
    public float topBounds = 30.0f;

    public float lowerBounds = -10.0f;
    public int invent;
    // Update is called once per frame
    void Update()
    {
        //same as the destroy out of bounds script, but does not display the game over log, nor reset the game timer
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
        }
    }
}
