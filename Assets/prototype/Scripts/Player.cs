using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    private bool isGrounded, isJumping;
    public float jumpVelocity = 10f;

    float movement = 0f;
    public float movementSpeed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isGrounded == true && gameObject != null)
        {
            isJumping = true;
            isGrounded = false;
            rb.velocity = Vector2.up * jumpVelocity;
        }
        else if (isJumping == true && gameObject != null)
        {
            isJumping = false;
        }

        movement = Input.GetAxis("Horizontal") * movementSpeed;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localRotation = Quaternion.Euler(0f, -180f, 0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
}