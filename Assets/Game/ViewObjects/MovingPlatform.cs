using UnityEngine;

public class MovingPlatform : Platform
{
    public float Speed;
    public Transform[] Points;
    public int StartingPointIndex;
    private int CurrentPointIndex;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = Points[StartingPointIndex].position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, Points[CurrentPointIndex].position) < 0.002)
        {
            CurrentPointIndex++;
            if (CurrentPointIndex == Points.Length)
            {
                CurrentPointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, Points[CurrentPointIndex].position, Speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }
}
