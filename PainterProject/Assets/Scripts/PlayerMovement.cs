using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 5f;
    private float horizontalSpeed;
    private float currentSpeed;
    private float jumpingPower = 7f;
    private bool isFacingRight = true;
    public Rigidbody2D rb2d;
    public Transform groundCheck;
    public LayerMask groundlayer;
    public AnimationCurve movementCurve;
    public AnimationCurve decelerationCurve;
    public float time;

    

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && rb2d.velocity.y > 0f)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, rb2d.velocity.y * 0.5f);
        }

        if (Input.GetButton("Horizontal"))
        {
            speed = movementCurve.Evaluate(time);
            time += Time.deltaTime;
        }
        else
        {
            currentSpeed = speed;
            speed = Mathf.MoveTowards(currentSpeed, 0, decelerationCurve.Evaluate(time));
            time += Time.deltaTime;
        }

        if (Input.GetButtonUp("Horizontal"))
        {
            time = 0;
        }
        if (Input.GetButtonDown("Horizontal"))
        {
            time = 0;
        }
        horizontalSpeed = horizontal * speed;

        Flip();
    }

    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(horizontal * speed, rb2d.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundlayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
