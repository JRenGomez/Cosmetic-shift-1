using UnityEngine;
using UnityEngine.SceneManagement; // To load new scenes


public class pDoor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Object entered trigger: " + other.gameObject.name);

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player entered the win zone!");
            // Load the next scene
            SceneManager.LoadScene("Game");  // Ensure the scene name matches exactly
        }
    }

}
