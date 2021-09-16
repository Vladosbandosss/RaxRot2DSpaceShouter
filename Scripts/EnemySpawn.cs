using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    private float minY = -4.4f;
    private float maxY = 4.4f;
    [SerializeField] GameObject enemyShip;
    [SerializeField] GameObject asteroid;
    [SerializeField] GameObject enemyBullet;
    [SerializeField] float repeatTime = 1f;
    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, repeatTime);
    }

    void SpawnEnemy()
    {
        int variant = Random.Range(0, 3);

        if (variant == 0)//корабль
        {
            float spawnY = Random.Range(minY, maxY);
            Vector3 spawn = new Vector3(transform.position.x, spawnY,transform.position.z);
            Instantiate(enemyShip, spawn, enemyShip.transform.rotation);
            
        }
        else//комету
        {
            float spawnY = Random.Range(minY, maxY);
            Vector3 spawn = new Vector3(transform.position.x, spawnY, transform.position.z);
            Instantiate(asteroid, spawn, Quaternion.identity);
        }
    }

    
}
