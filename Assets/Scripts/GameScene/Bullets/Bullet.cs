using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

   public float speed = 10f;
   public int damage = 10;
   public Rigidbody2D rb;

    private float timer;


    void Start()
    {

        damage = 10;
        rb.velocity = transform.right * speed;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer > 2)
        {
            Destroy(gameObject);
        }
    }

    //Bullet hits enemy and does dmg
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.CompareTag("Enemy"))
        {
            Debug.Log(hitInfo.name);
            
            Enemy enemy = hitInfo.GetComponent<Enemy>();



            if (enemy != null)
            {
                enemy.TakeDamage(damage);
                

            }
            Destroy(gameObject);
            }

        //Bullet hits player and does dmg
       /* if (hitInfo.CompareTag("Player"))
        {
            Debug.Log(hitInfo.name);

        Player player = hitInfo.GetComponent<Player>();

            if (player != null)
            {
                player.TakeDamage(damage);
               

            }
            Destroy(gameObject);
            }*/
       }
}
