using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador01 : MonoBehaviour
{
    [SerializeField] private GameObject enemy01;
    [SerializeField] private float initTime;
    [SerializeField] private float repeatTime;
    void Start()
    {
        InvokeRepeating("GenerateEnemy01", initTime, repeatTime);
    }

    public void GenerateEnemy01()
    {
        Instantiate(enemy01, transform.position, transform.rotation);
    }
}
