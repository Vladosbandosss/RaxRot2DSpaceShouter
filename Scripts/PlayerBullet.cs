using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
  
    [SerializeField] float speed = 3f;
    [SerializeField] GameObject explose;

    private void Start()
    {
      
    }
    void Update()
    {
        MoveBullet();
    }
    void MoveBullet()
    {
      
        Vector3 temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position = temp;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Aster"))
        {
           GameObject exp = Instantiate(explose, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Destroy(exp, 5f);
            GameManager.instanse.incrementScore();
            DestrSoinds.instance.ExploseSound();
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameObject exp = Instantiate(explose, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Destroy(exp, 5f);
            GameManager.instanse.incrementScore();
            DestrSoinds.instance.ExploseSound();
        }
    }
}
