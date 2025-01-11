using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // Import the TextMeshPro namespace

public class GameManager2 : MonoBehaviour
{
    [SerializeField]
    private float _timeToWaitBeforeExit = 3.0f; // Time to wait before exiting on death
    [SerializeField]
    private TextMeshProUGUI timerText; // Reference to the TextMeshProUGUI for the timer
    private float _survivalTime = 180.0f; // Time the player must survive
    private float _currentTime;
    private bool _isGameActive;

    void Start()
    {
        // Initialize the timer
        _currentTime = _survivalTime;
        _isGameActive = true;
    }

    void Update()
    {
        if (_isGameActive)
        {
            // Update the timer
            _currentTime -= Time.deltaTime;

            // Update the timer display
            if (timerText != null)
            {
                timerText.text = $"Time: {Mathf.Ceil(_currentTime)}s";
            }

            // Check if the survival time is over
            if (_currentTime <= 0)
            {
                NextLevel();
            }
        }
    }

    public void OnPlayerDied()
    {
        _isGameActive = false; // Stop the timer
        Invoke(nameof(EndGame), _timeToWaitBeforeExit);
    }

    private void EndGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void NextLevel()
    {
        _isGameActive = false; // Stop the timer
        SceneManager.LoadScene("Level_2"); // Load Level 2 scene
    }
}
