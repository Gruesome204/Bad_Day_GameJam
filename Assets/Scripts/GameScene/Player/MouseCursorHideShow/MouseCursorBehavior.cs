using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursorBehavior : MonoBehaviour
{
    public GameObject ui_gameobject; //Attach this in the Inspector


void Update()
    { 
        if (ui_gameobject.activeSelf)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
