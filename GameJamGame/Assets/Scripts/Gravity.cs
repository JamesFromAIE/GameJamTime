using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    [SerializeField] float gravity = 9.8f;
    Rigidbody Rb;

    private void Start()
    {
        Rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
            Rb.AddRelativeForce(new Vector3(0, -gravity, 0), ForceMode.Acceleration);
    }
}
