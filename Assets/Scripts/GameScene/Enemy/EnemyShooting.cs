using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyShooting : MonoBehaviour
{
    public GameObject bulletPrefab;


    public Transform firePoint;

    private float timer;

    [SerializeField] float shootingSpeed = 2;
    [SerializeField] int shootingDistance = 10;
    private GameObject player;
    private GameObject enemy;

    [SerializeField] private AudioSource enemyShootingEffectSound;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy");

        shootingSpeed  = 2;
        shootingDistance = 12;

    }


    private void Update()
    {
        if(player != null) { 
        float distance = Vector2.Distance(transform.position, player.transform.position);
            //Debug.Log(distance);
            if (distance <= shootingDistance)
            {
                timer += Time.deltaTime;

                if (timer > shootingSpeed)
                {
                    timer = 0;

                    shoot();
                        enemyShootingEffectSound.Play();
                }
            }
        }
    }

    void shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

}
