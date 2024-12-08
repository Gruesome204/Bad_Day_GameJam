using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CastleDoorScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D player)
    {


        if (player.CompareTag("Player"))
        {
            SceneManager.LoadScene("Ende");

        }
    }
}
