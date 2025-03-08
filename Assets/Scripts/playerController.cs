using NUnit.Framework.Interfaces;
using System;
using UnityEditor.Tilemaps;
using UnityEngine;
using static UnityEditor.Progress;

public class playerController : MonoBehaviour
{
    //body/sptites
    private Rigidbody2D rb;
    public float speed;
    private float InputX;

    //jumps
    public float jumpForce;
    [SerializeField]
    bool isGrounded;

    public mask_SO[] masks; // Array of SO masks
    public Transform spawnPoint; // Assign a spawn point in Unity
    private int currentIndex = 0;
    private GameObject currentItem;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        InputX = Input.GetAxisRaw("Horizontal");

        // Movement should apply to the master object (pPlayer)
        rb.linearVelocity = new Vector2(InputX * speed, rb.linearVelocity.y);

        // Rotate child object (PlayerPrefab) for direction change
        Transform playerVisual = transform.Find("PlayerPrefab");
        if (playerVisual != null)
        {
            playerVisual.localEulerAngles = InputX > 0
                ? new Vector3(0, 0, 0)
                : InputX < 0
                    ? new Vector3(0, 180, 0)
                    : playerVisual.localEulerAngles;
        }
    }


    private void Update()
    {
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }

        if (InputX > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (InputX < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);

        }


        //masks
        if (Input.GetKeyDown(KeyCode.E))
        {
            CycleMasks();
        }
    }


    void CycleMasks()
    {
        if (masks.Length == 0) return;

        if (currentItem != null) Destroy(currentItem); // Clean up the old mask

        // Search for the first child (if it's unnamed or nested differently)
        Transform playerVisual = transform.GetChild(0); // Modify index if PlayerPrefab is not first child

        currentItem = new GameObject("MaskItem");
        currentItem.transform.SetParent(playerVisual); // Parent to the correct object
        currentItem.transform.localPosition = spawnPoint.localPosition; // Correct relative position

        // Assign sprite and sorting order
        SpriteRenderer sr = currentItem.AddComponent<SpriteRenderer>();

        if (sr != null && masks[currentIndex] != null)
        {
            sr.sprite = masks[currentIndex].itemSprite;
            sr.sortingOrder = 2; // Ensure it's in front
        }

        // Scale down the mask by a factor of 2
        currentItem.transform.localScale = new Vector3(0.3f, 0.3f, 1); // Shrink by half

        currentIndex = (currentIndex + 1) % masks.Length;
    }
        private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        print("Grouneded");

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
        print("Not Grouneded");

    }
}

