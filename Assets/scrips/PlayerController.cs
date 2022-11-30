using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float Speed = 3f;
    [SerializeField] private float JumpSpeed = 3f;
    private Rigidbody2D rig;
    public bool betterJump = false;//
    public float fallMultipler = 0.5f;//
    public float lowJumpMultiplier = 1f;//
    public SpriteRenderer spriteRenderer;
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rig.velocity = new Vector2(Speed, rig.velocity.y);
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rig.velocity = new Vector2(-Speed, rig.velocity.y);
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        }
        else
        {
            rig.velocity = new Vector2(0, rig.velocity.y);
            animator.SetBool("Run", false);
        }
        if(Input.GetKey("space") && CheckGround.isGrounded)
        {
            rig.velocity = new Vector2(rig.velocity.x, JumpSpeed);

        }

        if(CheckGround.isGrounded == false)
        {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
        if (CheckGround.isGrounded == true)
        {
            animator.SetBool("Jump", false);
        }


            if (betterJump)//
        {
            if (rig.velocity.y < 0)
            {
                rig.velocity += Vector2.up * Physics2D.gravity.y * (fallMultipler) * Time.deltaTime;
            }
            if (rig.velocity.y > 0 && !Input.GetKey("space"))
            {
                rig.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier) * Time.deltaTime;
            }
        }//
           
    }


}
