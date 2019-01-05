using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float sensitivityX = 10f;
    public float sensitivityY = 10f;

    public float rotationY;
    void Update()
    {
        float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;
        rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
        rotationY = Mathf.Clamp(rotationY, -80, 80);
        
        transform.localEulerAngles = new Vector3(-rotationY, rotationX,0);
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
