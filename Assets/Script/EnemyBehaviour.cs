using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject enemyBall;
    [SerializeField] private float speedX = 2f;
    [SerializeField] private float speedZ = 2f;
    [SerializeField] private int enemyType; //Enemigo01: 1 - Enemigo02: 2
    [SerializeField] private float speedXEnemy02 = 4f;
    private float randomTime = 0f;
    [SerializeField] private float limiteInferiorZ = -18f;

    void Start()
    {
        switch (enemyType)
        {
            case 1:
                InvokeRepeating("ShootBall", 0f, 2f);
                break;
            case 2:
                Invoke("ShootBall", randomTime);
                break;
        }
    }

    void Update()
    {
        MoveEnemy();
    }


    public void ShootBall()
    {
        Instantiate(enemyBall, transform.position,transform.rotation);
        if(enemyType == 2)
        {
            randomTime = Random.Range(1f, 3f);
            Invoke("ShootBall", randomTime);
        }
    }

    public void MoveEnemy(){
        switch (enemyType)
        {
            case 1:
                transform.Translate(speedX * Time.deltaTime, 0f, speedZ * Time.deltaTime);
                if(transform.position.z < limiteInferiorZ)
                {
                    Destroy(gameObject);
                }
                break;
            case 2:
                if (transform.position.x < -6.8f || transform.position.x > 6.8f)
                {
                    speedXEnemy02 *= -1;
                }
                transform.Translate(speedXEnemy02 * Time.deltaTime, 0f, 0f);
                break;
        }
    }
}
