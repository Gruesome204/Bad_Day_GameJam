using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossKillScript : MonoBehaviour
{

    public GameObject CastleDoorOpen;
    public GameObject CastleDoorClosed;

    [SerializeField] GameObject destroyed;

    private void Start()
    {
        CastleDoorOpen.SetActive(false);
        CastleDoorClosed.SetActive(true);
    }

    private void OnDestroy()
    {
        if (CastleDoorOpen != null) { 

        CastleDoorOpen.SetActive(true);

        CastleDoorClosed.SetActive(false);
    }



       // SceneManager.LoadScene("MainMenu");
    }

}
