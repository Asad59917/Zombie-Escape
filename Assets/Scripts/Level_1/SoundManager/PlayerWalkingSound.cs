using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkingSound : MonoBehaviour
{
    public AudioSource walkingAudioSource; // Reference to the AudioSource
    public float walkingThreshold = 0.1f;  // Minimum movement speed to play sound

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Check if the player is moving
        if (rb.velocity.magnitude > walkingThreshold)
        {
            if (!walkingAudioSource.isPlaying)
            {
                walkingAudioSource.Play(); // Start walking sound
            }
        }
        else
        {
            if (walkingAudioSource.isPlaying)
            {
                walkingAudioSource.Stop(); // Stop walking sound
            }
        }
    }
}


