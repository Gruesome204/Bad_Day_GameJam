using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_no_rotation : MonoBehaviour {


    public Transform followTransform;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (followTransform != null) {


              this.transform.position = new Vector3(followTransform.position.x, this.transform.position.y, this.transform.position.z);
        }

    }
}
