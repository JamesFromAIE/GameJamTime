using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    //vars
    [SerializeField] float rotationSpeed;
    private float mouseX;
    private float mouseY;

    Transform target;


    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -60, 40);

        transform.LookAt(target);

        target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
    }

}
