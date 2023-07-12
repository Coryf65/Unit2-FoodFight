using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> _animalPrefabs;
    [SerializeField] private int spawnStartDelay = 2;
    [SerializeField] private float spawnRepeatRate = 1.5f;
    
    private int randomNumber;
    private float spawnRangeX = 20;
    private float spawnPositionZ = 20;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnStartDelay, spawnRepeatRate);
    }

    /// <summary>
    /// Spawns an animal from our List at positions between the Ranges (spawnRangeX +-) and at the spawnPositionZ
    /// </summary>
    void SpawnRandomAnimal()
    {
        randomNumber = Random.Range(0, _animalPrefabs.Count);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
            
        Instantiate(_animalPrefabs[randomNumber], spawnPosition, _animalPrefabs[randomNumber].transform.rotation);
    }
}