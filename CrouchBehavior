using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{ 
    public CharacterController playerHeight;
    public CapsuleCollider playerCol;
    public float normalHeight, crouchHeight;
    public Transform player;

    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            //this code makes it so the player gets shorter
            playerHeight.height = crouchHeight;
            playerCol.height = crouchHeight;
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            //this makes the player return to its uncrouched state. 
            playerHeight.height = normalHeight;
            playerCol.height = normalHeight;
            player.position = player.position;
        }
    }
}
