using UnityEditor.Tilemaps;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float maxSpeed;
    private Rigidbody2D myRB;
    bool facingRight;
    //Animator myAnimator;
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
       // myAnimator = GetComponent<Animator>();

        facingRight = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
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
