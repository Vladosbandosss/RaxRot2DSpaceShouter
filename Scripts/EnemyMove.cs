using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] bool canShoot;
    [SerializeField] bool canRotate;
    [SerializeField] float moveSpeed;
    [SerializeField] float rotationSpeed;
    [SerializeField] GameObject enemyBullet;

    private void Start()
    {
        if (canShoot)
        {
            InvokeRepeating(nameof(Shoouting), 1f, 3f);
        }
    }
    void Update()
    {
        MoveEnemy();
    }
    void MoveEnemy()
    {
        if (canRotate)
        {
            transform.Rotate(0, 0, rotationSpeed);
            Vector3 temp = transform.position;
            temp.x += moveSpeed * Time.deltaTime;
            transform.position = temp;
        }
        if (canShoot)
        {
            Vector3 temp = transform.position;
            temp.x += moveSpeed * Time.deltaTime;
            transform.position = temp;
          
           
            
        }
    }
    void Shoouting()
    {
        Instantiate(enemyBullet, transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Game");
            
        }
    }



}
