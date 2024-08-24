using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolScriptUpload : MonoBehaviour
{
    public float speed = 50.0f;
    // Update is called once per frame
    void Update()
    {
        //move GameObject forward
        transform.Translate(Vector3.forward *Time.deltaTime * speed);
    }
}
