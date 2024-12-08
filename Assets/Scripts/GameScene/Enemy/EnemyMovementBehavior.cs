using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBehavior : MonoBehaviour
{

    private GameObject player;
   // public Transform player;
    public float movement_speed = 2.0f;

    bool StartWalking;
    // Use this for initialization

   public  float oldPosX;
   public float oldPosZ;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");


         oldPosX = transform.position.x;
         oldPosZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
  

            if (player != null)
            {
                Vector3 delta = player.transform.position - transform.position;
                delta.y = 0;
                delta.Normalize();
                float moveSpeed = movement_speed * Time.deltaTime;
                transform.position = transform.position + (delta * moveSpeed);

       

            }

        }


    void Flip()
    {
        transform.Rotate(0f, 180f, 0f);
    }
   
}