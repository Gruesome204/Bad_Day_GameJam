using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_nonRotate : MonoBehaviour
{
    private Quaternion rotation;

    void Awake()
    {
        rotation = transform.rotation;
    }

    void LateUpdate()
    {
        transform.rotation = rotation;
    }
}
