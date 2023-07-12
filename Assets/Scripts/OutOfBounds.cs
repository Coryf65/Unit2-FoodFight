using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    [Header("Destroy this object when it goes out of bounds")] 
    [SerializeField] private int _topBoundary = 50;
    [SerializeField] private int _lowerBoundary = -10;
    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > _topBoundary)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < _lowerBoundary)
        {
            Destroy(gameObject);
            Debug.Log("Game Over...");
        }
    }
}