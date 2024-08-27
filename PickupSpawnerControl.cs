using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class PickupSpawnerControl : MonoBehaviour
{
    public GameObject[] pickupFabs; //array to store pickup objects
    
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;
    private float startDelay =2;
    private float spawnInterval = 5.5f;
    private int pickupIndex;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandompickUp", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandompickUp()
    {
        Vector3 spawnPos= new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
        int ufoIndex = Random.Range(0, pickupFabs.Length); // picks a random pickup from the array
        Instantiate(pickupFabs[pickupIndex], spawnPos, pickupFabs[pickupIndex].transform.rotation); 
        //spawns a indexed pickup from the array at a random location on the x axis
    }
}
