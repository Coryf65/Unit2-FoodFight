using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Range(1, 20)]
    [SerializeField] private float _speed = 1.0f;
    [Range(1, 50)]
    [Tooltip("Player boundary range of (+ x) to (- x) to what number is entered")]
    [SerializeField] private float _boundaryRange = 10;
    public float _horizontalInput;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -_boundaryRange)
        {
            transform.position = new Vector3(-10, transform.position.y);
        }

        if (transform.position.x > _boundaryRange)
        {
            transform.position = new Vector3(10, transform.position.y);
        }
        
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * _horizontalInput * Time.deltaTime * _speed);
    }
}
