using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float speed;
    public float smooth;
    Rigidbody2D rb2d;
    public bool facingRight;
    public float jumpForce;
    bool grounded;
    public Collider2D groundCheck;
    public LayerMask groundLayer;
    Animator anim;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        facingRight = true;
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        //;;;;
        //llll

        grounded = groundCheck.IsTouchingLayers(groundLayer);
        float x = Input.GetAxisRaw("Horizontal");

        anim.SetBool("Running", x != 0);
        anim.SetBool("Jumping", !grounded);

        Vector2 targetvelocity = new Vector2(x * speed, rb2d.velocity.y);
        rb2d.velocity = Vector2.SmoothDamp(rb2d.velocity, targetvelocity, ref targetvelocity, Time.deltaTime * smooth);
        if (x > 0 && !facingRight)
        {
            // ... flip the player.
            Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (x < 0 && facingRight)
        {
            // ... flip the player.
            Flip();
        }

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
            rb2d.AddForce(new Vector2(0f, jumpForce));
    }


    void Flip()
    {
        //Invert the facingRight variable
        facingRight = !facingRight;

        //Flip the Character
        Vector2 scale = transform.localScale;

        scale.x *= -1;

        transform.localScale = scale;


    }


}
