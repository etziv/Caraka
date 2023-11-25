using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;

    private Animator anim;
    private enum MovementState { idle, run, jump, fall, attack}

    private float dirX = 0f;
    [SerializeField] public float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;

    [SerializeField] private LayerMask groundCheck;

    private Transform sprite;

    private bool faceRight = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll  = GetComponent<BoxCollider2D>();
        sprite = GetComponent<Transform>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new  Vector2(dirX * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        UpdateAnimationState();

    }

    private void UpdateAnimationState()
    {

        MovementState state;

         if (dirX > 0f)
        {
            state = MovementState.run;
            if (!faceRight)
            {
                faceRight = !faceRight;
                transform.Rotate(0f, 180f, 0f);
            }
        }
        else if (dirX < 0f)
        {
            state = MovementState.run;
            if (faceRight)
            {
                faceRight = !faceRight;
                transform.Rotate(0f, 180f, 0f);
            }
        }
        else
        {
            state = MovementState.idle;
        }
        if (rb.velocity.y > .1f)
        {
            state = MovementState.jump;
        }

        else if (rb.velocity.y < -.1f)
        {
            state = MovementState.fall;
            rb.gravityScale = 3f;
        }

        anim.SetInteger("state", (int)state);
    }


    public bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, groundCheck );
    }

}
