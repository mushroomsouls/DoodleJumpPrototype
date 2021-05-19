using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool isGrounded, isJumping;
    private Rigidbody2D rb;
    [SerializeField] private float speedMultiplier = 0f;
    public float jumpVelocity = 10f, jumpTimerCounter, jumpTime;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isGrounded == true)
        {
            isJumping = true;
            isGrounded = false;
            jumpTimerCounter = jumpTime;
            rb.velocity = Vector2.up * jumpVelocity;
        }
        else if (isJumping == true)
        {
            if (jumpTimerCounter > 0)
            {
                rb.velocity = Vector2.up * jumpVelocity;
                jumpTimerCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Time.deltaTime * speedMultiplier);
            if (speedMultiplier <= 15f)
                speedMultiplier += Time.deltaTime * 15f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speedMultiplier);
            if (speedMultiplier <= 15f)
                speedMultiplier += Time.deltaTime * 15f;
        }
        else
        {
            if (speedMultiplier >= 0f)
                speedMultiplier -= Time.deltaTime * 25f;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            speedMultiplier = 3f;
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            speedMultiplier = 3f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
}