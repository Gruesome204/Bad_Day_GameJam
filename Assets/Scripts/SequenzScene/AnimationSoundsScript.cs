using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSoundsScript : MonoBehaviour
{ 

        [SerializeField] private AudioSource Truck_Drive;
        [SerializeField] private AudioSource Truck_Crash;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AudioSound());

       
    }

    IEnumerator AudioSound()
    {
        Truck_Drive.Play();

        yield return new WaitForSeconds(1);
        Truck_Crash.Play();
    }

    // Update is called once per frame
    void Update()
    { 

        timer += Time.deltaTime;

        if (timer > 1)
        {
           // Truck_Drive.Stop();
        }

        if (timer > 2)
        {      
           // Truck_Crash.Play();
        }
    }
}
