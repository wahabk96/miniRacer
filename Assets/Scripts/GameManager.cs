using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Transform finishLine; // Set this in the Inspector to the finish line's transform
    public Transform playerCar; // Set this in the Inspector to the player's car transform
    public FireworkController fireworkController; // Reference to the FireworkController script
    public Canvas winningCanvas; // Reference to the Canvas displaying the winning message
    public Text winningMessageText; // Reference to the Text component displaying the winning message
    public AudioClip crowdCheeringSound;
    public AudioSource audioSource;
    bool raceWon = false;

    void Update()
    {
        // Check if the player's car has crossed the finish line
        if (!raceWon && playerCar.position.z > finishLine.position.z)
        {
            // Player wins
            raceWon = true;
            DisplayWinningMessage();
            StartFireworks();
            PlayCrowdCheeringSound();
        }
    }

    void DisplayWinningMessage()
    {
        // Activate the winning canvas and set the winning message
        winningCanvas.gameObject.SetActive(true);
        winningMessageText.text = "Congratulations! You've won!";
    }
    

    void StartFireworks()
    {
        // Trigger the fireworks using the FireworkController script
        fireworkController.StartFireworks();
    }
    void PlayCrowdCheeringSound()
    {
        audioSource.clip = crowdCheeringSound;
        audioSource.Play();
    }
}

