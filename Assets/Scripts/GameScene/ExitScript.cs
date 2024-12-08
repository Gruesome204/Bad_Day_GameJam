using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour
{
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape clicked");
            SceneManager.LoadScene("MainMenu");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("Escape clicked");
            SceneManager.LoadScene("Ende");

        }

    }
}
