using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protagonista : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public bool pulando;
    public bool puloduplo;

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        Move();
        Jump();
    }

    void inputCheck()
    {
    
    }

    void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && pulando == false )
        {
            rb2d.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3) 
        {
            pulando = false;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            pulando = true;
        }
    }

    void Flip()
    {
    
    
    
    
    }




}
