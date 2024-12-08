using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuBehavior : MonoBehaviour
{

    public Button credits;
    public GameObject creditsPanel;
    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        credits.onClick.AddListener(CreditOnClick);
    }

    private void CreditOnClick()
    {
        if(creditsPanel != creditsPanel.activeSelf)
        {
            creditsPanel.SetActive(true);
        }
        else
        {
            creditsPanel.SetActive(false);
        }
    }
}
