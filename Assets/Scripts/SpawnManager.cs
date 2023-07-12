using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] private List<GameObject> _animalPrefabs;
    
    private int randomNumber;
    private float spawnRangeX = 20;
    private float spawnPositionZ = 20;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            randomNumber = Random.Range(0, _animalPrefabs.Count);
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
            
            Instantiate(_animalPrefabs[randomNumber], spawnPosition, _animalPrefabs[randomNumber].transform.rotation);
        }
    }
}