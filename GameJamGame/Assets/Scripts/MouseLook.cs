using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    //vars
    [SerializeField] float rotationSpeed;
    private float mouseX;
    private float mouseY;

    [SerializeField] Transform Head;
    [SerializeField] Transform Body;

    private void Update()
    {
        CamControl();
    }
    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -60, 40);

        transform.LookAt(Body);

        Body.rotation = Quaternion.Euler(0, mouseX, 0);
        Head.rotation = Quaternion.Euler(mouseY, mouseX, 0);
    }

}
