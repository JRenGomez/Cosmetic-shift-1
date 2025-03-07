using UnityEngine;

public class TestPlayer : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public float JumpForce = 5f;
    public Rigidbody2D ThisRigidbody2D;
    private Vector2 Movement;
    private bool IsGrounded;

    void Start()
    {
    }
    void Update()
    {

        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = 0f;
        if (Input.GetButtonDown("Jump") && IsGrounded)
        {
            ThisRigidbody2D.linearVelocity = new Vector2(ThisRigidbody2D.linearVelocity.x, JumpForce);
            IsGrounded = false;
        }
    }

    private void FixedUpdate()
    {
        ThisRigidbody2D.linearVelocity = new Vector2(Movement.x * MoveSpeed, ThisRigidbody2D.linearVelocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.contacts[0].normal.y > 0.5f)
        {
            IsGrounded = true;
        }
    }



}
