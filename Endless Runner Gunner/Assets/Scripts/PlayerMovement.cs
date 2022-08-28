using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    //private Rigidbody2D rb;
    private BoxCollider2D coll;
    //private SpriteRenderer sprite;
    private Animator anim;
    private enum MovementState {walk, jump, fall};


    public Rigidbody2D rb;
    public float moveSpeed;
    private SpriteRenderer sr;

    public float jumpForce;
    private float moveInput;

    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    public float jumpStartTime;
    private float jumpTime;
    private bool isJumping;
    [SerializeField] private AudioSource jump_sound_effect;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        //FaceMoveDirection();
        Jump();
        UpdateAnimationUpdate();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
    }

    void Jump()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if (isGrounded == true && Input.GetButtonDown("Jump"))
        {
            isJumping = true;
            jumpTime = jumpStartTime;
            rb.velocity = Vector2.up * jumpForce;
            jump_sound_effect.Play();
        }

        if (Input.GetButton("Jump") && isJumping == true)
        {
            if (jumpTime > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTime -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }

        if (Input.GetButtonUp("Jump"))
        {
            isJumping = false;
        }
    }

    private void UpdateAnimationUpdate()
    {

        MovementState state;

        if (rb.velocity.y > .1f)
        {
            state = MovementState.jump;
        }

        else if (rb.velocity.y < -.1f)
        {
            state = MovementState.fall;
        }

        else
        {
            state = MovementState.walk;
        }

        anim.SetInteger("state", (int)state);
    }

}

