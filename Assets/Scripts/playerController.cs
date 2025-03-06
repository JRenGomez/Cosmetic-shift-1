using UnityEditor.Tilemaps;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // movement variables 
    public float maxSpeed;

    // jumping variables
    bool grounded = false;
    float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    public Transform groundCheck;
    public float jumpHeight;

    private Rigidbody2D myRB;
    bool facingRight;
     Animator myAnim;
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        // myAnimator = GetComponent<Animator>();
        facingRight = true;
    }

    private void Update()
    {
        if (grounded && Input.GetAxis("Jump")>0) {
            grounded = false;
            myRB.AddForce(new Vector2(0, jumpHeight));

        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //check if we are grounded - if no, then we are falling
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        myAnim.SetFloat("verticalSpeed", myRB.velocity.y);



        float move = Input.GetAxis("Horizontal");
        myRB.velocity = new Vector2(move*maxSpeed, myRB.velocity.y);
        if (move > 0 && !facingRight)
        {
            flip();
        }
        else if (move < 0 && facingRight)
        {
            flip();

        }
    }

    void flip()
    {
        facingRight =!facingRight;
        Vector2 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
