using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; //array to store UFO ships

    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;
    private float startDelay =2;
    private float spawnInterval = 1.5f;         
    private int ufoIndex;
    

    void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }
    
    void SpawnRandomUFO()
    {
        Vector3 spawnPos= new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
        int ufoIndex = Random.Range(0, ufoPrefabs.Length); // picks a random ufo from the array
        Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation); 
        //spawns a indexed ufo from the array at a random location on the x axis
    }
}
