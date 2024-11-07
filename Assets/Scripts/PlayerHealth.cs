using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int lives = 3;             
    public TextMeshProUGUI livesText;  

    void Start()
    {
        // Ensure the UI starts with the correct number of lives
        UpdateLivesText();
    }

    // Trigger event when player collides with an enemy
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object collided with is tagged as "Enemy"
        if (other.CompareTag("Enemy"))
        {
            lives--;  // Decrease lives on collision

            UpdateLivesText();  // Update the lives text UI

            if (lives <= 0)
            {
                // Restart the scene when lives are 0 or less
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    // Update the UI text to display current lives
    void UpdateLivesText()
    {
        livesText.text = "Lives: " + lives;
    }
}
