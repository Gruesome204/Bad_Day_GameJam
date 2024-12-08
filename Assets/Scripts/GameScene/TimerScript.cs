using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    [SerializeField]public float time;
    public TextMeshProUGUI timerDisplay;

    void Start()
    {
        time = 0;
    }

    void Update()
    {
        time += 1 * Time.deltaTime;
        timerDisplay.text = time.ToString("Timer: " + "0.00");
    }
}
