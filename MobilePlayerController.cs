using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilePlayerController : MonoBehaviour
{
    // Player Stats
    [Header("Player Stats")]
    public float speed;
    public float jumpForce;

    // Player RigidBody
    [Header("RigidBody Component")]
    private Rigidbody2D rb;

    // Player Jump
    [Header("Player Jump Settings")]
    private bool isGrounded = true;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private bool jump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if player is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        // Check for touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Move player horizontally based on touch position
            if (touch.phase == TouchPhase.Moved)
            {
                float moveDirection = Mathf.Sign(touch.deltaPosition.x);
                rb.velocity = new Vector2(moveDirection * speed, rb.velocity.y);
            }

            // Jump if player is grounded and touch is tapped
            if (touch.phase == TouchPhase.Ended && isGrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
        }
    }
}
