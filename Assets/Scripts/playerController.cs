using System;
using UnityEditor.Tilemaps;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private float InputX;

    public float jumpForce;
    [SerializeField]
    bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        InputX = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(InputX * speed, rb.velocity.y); 
    }

    private void Update()
    {
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        print("Grouneded");

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded= false;
        print("Not Grouneded");

    }
}

