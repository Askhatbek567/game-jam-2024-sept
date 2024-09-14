using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerState State;
    public float acceleration = 0;
    public float rotationSpeed = 0;
    public float rotationAcceleration = 0;
    private Rigidbody2D rb;
    private Vector2 _moveInput = Vector2.zero;
    public float lerpAmount = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _moveInput.x = Input.GetAxisRaw("Horizontal");
        _moveInput.y = Input.GetAxisRaw("Vertical");
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(_moveInput * acceleration);
        }
        Movement();
    }

    private void FixedUpdate()
    {
        rb.velocity = _moveInput * State.speed;
    }

    private void Movement()
    {
        float targetSpeed = _moveInput.x * State.speed;
        targetSpeed = Mathf.Lerp(rb.velocity.x, targetSpeed, lerpAmount);
    }

}