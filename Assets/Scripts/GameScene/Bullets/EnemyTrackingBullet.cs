using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrackingBullet : MonoBehaviour
{

    [SerializeField]  private GameObject player;
    private Rigidbody2D rb;
    public int damage = 10;
    [SerializeField] public float force;

    private float timer;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;

        float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot);

    }


    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 10)
        {
            Destroy(gameObject);
        }
    }



    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.CompareTag("Player"))
        {
            player.gameObject.GetComponent<Player>().TakeDamage(damage);
            Debug.Log("Player hit");

        }
            Destroy(gameObject);
        }

    }
