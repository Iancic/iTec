using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    public float moveSpeed;
    public Rigidbody2D theRB;
    public float jumpForce;

    private bool isGrounded;
    public Transform groundCheckPoint, transformP2;
    private float distance_x;
    public LayerMask whatIsGround;

    private bool canDoubleJump;

    private Animator anim;
    private SpriteRenderer theSR;

    public float knockBackX, knockBackF;
    private float knockBackCounter=1;

    public bool stopInput;
    void Awake(){
        instance = this;
    }
    void Start()
    {
        anim = GetComponent<Animator>();
        theSR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (!PauseMenu.instance.paused)
    {

        if (knockBackCounter <= 0)
        {
            theRB.velocity = new Vector2(moveSpeed * Input.GetAxisRaw("Horizontal_1"), theRB.velocity.y);

            isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, .2f, whatIsGround);

                if (isGrounded)
                {
                    canDoubleJump = true;
                }

                if (Input.GetButtonDown("Jump_1"))
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
        else
        {
            knockBackCounter -= Time.deltaTime;
            if (theSR.flipX == false)
            {
                theRB.velocity = new Vector2(-knockBackF, theRB.velocity.y);
            }
            else if (theSR.flipX == true)
            {
                theRB.velocity = new Vector2(knockBackF, theRB.velocity.y);
            }
        }
    }
    }
}
