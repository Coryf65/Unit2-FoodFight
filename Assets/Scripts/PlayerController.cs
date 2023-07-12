using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Range(1, 20)]
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private GameObject projectilePrefab = null;
    [Space]
    [Range(1, 50)]
    [Tooltip("Player boundary range of (+ x) to (- x) to what number is entered")]
    [SerializeField] private float _boundaryRange = 20;

    [SerializeField] private GameObject _foodSpawnPoint;

    private float horizontalInput;

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
        
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * _speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, _foodSpawnPoint.transform.position, projectilePrefab.transform.rotation);
        }
    }
}
