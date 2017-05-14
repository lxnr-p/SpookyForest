using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeRotation: MonoBehaviour
{
    public float xRotation = -90.0F;

    void Start() {
        //xRotation += Input.GetAxis("Vertical");
        transform.eulerAngles = new Vector3(-90, xRotation, 0);
    }


    void Example() {
        print(transform.eulerAngles.x);
        print(transform.eulerAngles.y);
        print(transform.eulerAngles.z);
    }
}
