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
    public SpriteRenderer theSR;

    public float knockBackLength, knockBackForce;
    private float knockBackCounter;

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
        if (knockBackCounter <= 0){
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
                        Audio.instance.PlaySFX(2);
                    }
                    else
                    {
                        if (canDoubleJump)
                        {
                            theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
                            Audio.instance.PlaySFX(2);
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
        } else {
            knockBackCounter -= Time.deltaTime;
            if (PlayerController.instance.theSR.flipX == false)
            {
                theRB.velocity = new Vector2(-knockBackForce, theRB.velocity.y);
            }
            else
            {
                theRB.velocity = new Vector2(knockBackForce, theRB.velocity.y);
            }
        }
        anim.SetBool("isGrounded", isGrounded);
        anim.SetFloat("moveSpeed", Mathf.Abs(theRB.velocity.x));

        if (Input.GetKeyDown(KeyCode.Joystick2Button2) && isGrounded)
           anim.Play("Player2_attack");

        if (Input.GetKeyDown(KeyCode.Joystick2Button2) && !isGrounded)
           anim.Play("Player2_kick");
    }
    }
    public void knock(){
        knockBackCounter = knockBackLength;
        theRB.velocity = new Vector2(0f, knockBackForce);
    }
}
