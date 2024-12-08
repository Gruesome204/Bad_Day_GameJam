using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{

    [SerializeField] private Slider slider;

     void Update()
    {
      
    }

    public void UpdateHealtBar(float maxHealth, float currentHealth)
    {
        slider.value = currentHealth / maxHealth;
        Debug.Log("Update Health");

    }


}