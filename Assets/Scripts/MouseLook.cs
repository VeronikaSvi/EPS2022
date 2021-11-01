using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    Vector2 rotation;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        rotation.x -= Input.GetAxis("Mouse Y");
        rotation.y += Input.GetAxis("Mouse X");
        transform.eulerAngles = rotation * speed;
    }
}
