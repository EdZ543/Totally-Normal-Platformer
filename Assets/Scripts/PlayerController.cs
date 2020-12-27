using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float speed;
    public float jumpForce;
    private float moveInput;
    private Rigidbody2D rb;
    public SpriteRenderer sr;
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private int extraJumps;
    public int extraJumpsValue;
    private Animator anim;



    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if(moveInput == 0){
            anim.SetBool("isRunning",false);
        }else{
            anim.SetBool("isRunning",true);
        }
        
        if(moveInput > 0){
        sr.flipX = false;
        }
        else if(moveInput < 0){
        sr.flipX = true;
        }
    }

    void Update()
    {
        if(isGrounded == true){
            extraJumps = extraJumpsValue;
        }

        if(isGrounded == true){
            anim.SetBool("isJumping", false);
        }else{
            anim.SetBool("isJumping", true);
        }
        
        if(Input.GetKey(KeyCode.UpArrow) && extraJumps > 0){
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        } else if (Input.GetKey(KeyCode.UpArrow) && extraJumps == 0 && isGrounded == true && rb.velocity.y <= 0.1){
            rb.velocity = Vector2.up * jumpForce;
        }

        if(Input.GetKey(KeyCode.W) && extraJumps > 0){
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        } else if (Input.GetKey(KeyCode.W) && extraJumps == 0 && isGrounded == true && rb.velocity.y <= 0.1){
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
