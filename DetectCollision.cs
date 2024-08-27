    using System;
using System.Collections;
using System.Collections.Generic;
    using Unity.VisualScripting;
    using UnityEngine;
    using UnityEngine.Playables;

    public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager;// score reference to score manager
    public int scoreToGive;
    public GameObject ufosound;
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();//find ScoreManager gameobject and reference ScoreManager script conponent
    }

    void OnTriggerEnter(Collider other)
   {
       if (other.gameObject.name == "Bolt_container(Clone)")
       { 
           scoreManager.IncreaseScore(scoreToGive);
           Destroy(gameObject); // destroy this game object
           Destroy(other.gameObject);
           Instantiate(ufosound);
       }
   }
}
