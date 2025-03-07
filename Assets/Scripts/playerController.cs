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

        rb.linearVelocity = new Vector2(InputX * speed, rb.linearVelocity.y); 
    }

    private void Update()
    {
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }

        if(InputX > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if( InputX < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);

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

