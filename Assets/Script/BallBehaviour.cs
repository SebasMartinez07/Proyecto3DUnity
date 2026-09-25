using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] private float speedZ = 5f;
    [SerializeField] private float limiteZ = 20f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, 0, speedZ * Time.deltaTime);

        if(transform.position.z > limiteZ || transform.position.z < -limiteZ)
        {
            Destroy(gameObject);
        }
    }
}
