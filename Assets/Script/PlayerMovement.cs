using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 4f;
    [SerializeField] private GameObject prefabBalaPlayer;
    [SerializeField] private Transform puntoDisparo;
    [SerializeField] private float cooldown = 0.3f;
    private float nextFire = 0f;

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")*speed*Time.deltaTime, 0f, 0f);

        if(Input.GetKeyDown(KeyCode.Space) && Time.time >= nextFire)
        {
            Instantiate(prefabBalaPlayer, puntoDisparo.position, Quaternion.identity);
            nextFire = Time.time + cooldown;
        }
    }
}