﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float gravity = 9.8f;
    [SerializeField] float jumpForce = 5.0f;
    [SerializeField] float maxGroundDistance = 1.5f;
    private bool isGrounded;
    [SerializeField] float forwardsJump = 1.0f;
    [SerializeField] LayerMask layerMask;
    [SerializeField] AudioSource LandSound;
    [SerializeField] bool GSphere;

    [SerializeField] ChargeUp chargeUp;
    [SerializeField] GameObject Player;
    Rigidbody Rb;


    //move vars
    [SerializeField] float MoveJump;
    [SerializeField] float MoveSpeed;
    bool inAir;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        LandSound = GetComponent<AudioSource>();
        Rb = Player.GetComponent<Rigidbody>();

    }

    void LateUpdate()
    {
        var colliders = Physics.OverlapSphere(transform.position, maxGroundDistance, layerMask);
        isGrounded = colliders.Length > 0;
        if (!isGrounded) { inAir = true; }
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Move();
        Gravity();
    }

    private void OnDrawGizmos()
    {
        if (GSphere)
        Gizmos.DrawSphere(transform.position, maxGroundDistance);
        Gizmos.DrawLine(transform.position, transform.position - new Vector3 (0, maxGroundDistance, 0));
    }

    void Jump()
    {
        if (Input.GetKeyUp("space") && Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
        {

            if (isGrounded)
            {
                Rb.AddRelativeForce(new Vector3(0.0f, jumpForce * chargeUp.percentage, forwardsJump * chargeUp.percentage), ForceMode.Impulse);
            }
        }
    }

    void Move()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0 && !Input.GetKey("space"))
        {
            if (!inAir)
            {
                Rb.AddRelativeForce(new Vector3(Input.GetAxisRaw("Horizontal") * MoveSpeed, MoveJump, Input.GetAxisRaw("Vertical") * MoveSpeed), ForceMode.Impulse);
            }
        }
    }

    void Gravity()
    {
        Rb.AddRelativeForce(new Vector3(0, -gravity, 0), ForceMode.Acceleration);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Rb.velocity = Vector3.zero;
        inAir = false;
    }
}
