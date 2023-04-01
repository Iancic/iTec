using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public static PlayerController2 instance;
    public float moveSpeed;
    public Rigidbody2D theRB;
    public float jumpForce;

    private bool isGrounded;
    public Transform groundCheckPoint;
    public LayerMask whatIsGround;

    private bool canDoubleJump;

    private Animator anim;
    private SpriteRenderer theSR;

    void Awake(){
        instance = this;
    }

    void Start()
    {
        anim = GetComponent<Animator>();
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.instance.paused)
    {
        theRB.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal_2"), theRB.velocity.y);

                isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, .2f, whatIsGround);

                if (isGrounded)
                {
                    canDoubleJump = true;
                }

                if (Input.GetButtonDown("Jump_2"))
                {
                    if (isGrounded)
                    {
                        theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
                        
                    }
                    else
                    {
                        if (canDoubleJump)
                        {
                            theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
                            canDoubleJump = false;
                            
                        }
                    }
                }

                if (theRB.velocity.x < 0)
                {
                    theSR.flipX = false;
                }
                else if (theRB.velocity.x > 0)
                {
                    theSR.flipX = true;
                }
    }
    }
}
