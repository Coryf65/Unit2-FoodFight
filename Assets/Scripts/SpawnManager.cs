using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] private List<GameObject> _animalPrefabs;
    private int randomNumber;

    // Update is called once per frame
    void Update()
    {
        randomNumber = Random.Range(0, _animalPrefabs.Count);
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(_animalPrefabs[randomNumber], new Vector3(0, 0, 20), _animalPrefabs[randomNumber].transform.rotation);
        }
    }
}
