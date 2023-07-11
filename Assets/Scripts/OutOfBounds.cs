using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    [Header("Destroy this object when it goes out of bounds")] 
    [SerializeField] private int _boundary = 50;
    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > _boundary)
        {
            Destroy(gameObject);
        }
    }
}
