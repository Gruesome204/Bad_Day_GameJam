using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfMapScript : MonoBehaviour
{
    [SerializeField] private GameObject player;



    private void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
    }
    void OnTriggerEnter2D(Collider2D player)
    {
    

        if (player.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameScene");

        }
    }
}
