using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 3f;

    private float maxY = 4.4f;
    private float minY = -4.4f;

    float currentTime = 0f;
    float atackTimer = 1f;
    bool canShoot = true;

    [SerializeField] GameObject bullet;
    void Update()
    {
        MovePlayer();
        Shoot();
    }

    private void Shoot()
    {
        currentTime += Time.deltaTime;
        if (currentTime > atackTimer)
        {
            canShoot = true;
        }
        if (Input.GetKeyDown(KeyCode.Space)&&canShoot)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            GameManager.instanse.ShootMusic();
            currentTime = 0;
            canShoot = false;
        }
    }

    void MovePlayer()
    {
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            Vector3 temp = transform.position;

            temp.y += speed * Time.deltaTime;

            if (temp.y > maxY)
            {
                temp.y = maxY;
            }

            transform.position = temp;
        }

        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            Vector3 temp = transform.position;

            temp.y -= speed * Time.deltaTime;

            if (temp.y < minY)
            {
                temp.y = minY;
            }

            transform.position = temp;
        }


    }
}
