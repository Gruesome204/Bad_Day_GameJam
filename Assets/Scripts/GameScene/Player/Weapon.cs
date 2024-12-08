using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Weapon : MonoBehaviour
{
   public Transform firePoint;
   public GameObject bulletPrefab;

    [SerializeField] public int amunition;
    public TextMeshProUGUI bulletAmount;


    private float timer;
    [SerializeField] Dialogue dialogue;



    [SerializeField] private AudioSource bulletShoot;


    private void Start()
    {

        amunition = 35;
        bulletAmount.text = amunition.ToString();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (amunition > 0)
        {
            if (timer > 1)
            {
              

                if (Input.GetButtonDown("Fire1"))
                {

                    timer = 0;
                        if (dialogue.DialogueIsOpen == false) {

                    bulletShoot.Stop();
                    Shoot();
                    bulletShoot.Play();
                    amunition = amunition - 1;
                }
                    }
            }

            bulletAmount.text = amunition.ToString();
        }

    }

        
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); ;
    }





}
