using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.TextCore.Text;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float speed = 1;
    [SerializeField] private float jumpForce = 200;
    [SerializeField] private Rigidbody rb;
    public Vector3 offset;
    public float newSpeed = 3;
    public float oldspeed = 1;
    public float runSpeed = 15;
    
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
   private void Update()
    {
        //this is movement 
        var vel = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"))* speed;
        vel.y = rb.velocity.y;
        rb.velocity = vel;
        //this will allow jumping to occur if C is not being pressed
        if (Input.GetButtonDown("Jump") && (!Input.GetKey(KeyCode.C)))
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
        //this makes the player walk slow when crouched.
        if (Input.GetKey(KeyCode.C))
        {
            speed=newSpeed;
        }
        else
        {
            speed = oldspeed;
        }
        //this allows for running
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed=runSpeed;
        }
        else
        {
            speed = oldspeed;
        }

    }
}
