using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class ParkingSpace : MonoBehaviour
{
    public Transform car; // Reference to the car's transform
    public float perfectDistance = 0.1f; // Adjust this distance based on your definition of a perfect park
    public float perfectRotation = 10f; // Adjust this angle based on your definition of a perfect park
    public int maxScore = 100; // Maximum score achievable

    void Update()
    {
        if (car != null)
        {
            CalculateScore();
        }
    }

    void CalculateScore()
    {
        float positionScore = CalculatePositionScore();
        float rotationScore = CalculateRotationScore();

        // Combine position and rotation scores to get the overall score
        float overallScore = Mathf.Clamp01((positionScore + rotationScore) / 2f);

        // Convert the overall score to an integer based on the maximum score
        int finalScore = Mathf.RoundToInt(overallScore * maxScore);

        Debug.Log("Score: " + finalScore);
    }

    float CalculatePositionScore()
    {
        float distance = Vector3.Distance(car.position, transform.position);

        // Calculate a normalized score based on the distance
        float positionScore = 1f - Mathf.Clamp01(distance / perfectDistance);

        return positionScore;
    }

    float CalculateRotationScore()
    {
        float angle = Quaternion.Angle(car.rotation, transform.rotation);

        // Calculate a normalized score based on the rotation angle
        float rotationScore = 1f - Mathf.Clamp01(angle / perfectRotation);

        return rotationScore;
    }
}*/
using UnityEngine.SceneManagement;

public class ParkingSpace : MonoBehaviour
{
    
   /* void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered parking space trigger.");
        if (other.CompareTag("Car")) // Assuming the player has the "Player" tag
        {
            Debug.Log("Player detected. Starting Level 1.");
            StartLevel1();
        }
    }*/
     void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entered parking space collision."); // Log to check if OnCollisionEnter is being called
        StartLevel1();
        if (collision.collider.CompareTag("Player")) // Assuming the player has the "Player" tag
        {StartLevel1();
            Debug.Log("Player detected. Starting Level 1."); // Log to check if the condition is satisfied
            //StartLevel1();
        }
    }

    void StartLevel1()
    {
        SceneManager.LoadScene("SampleScene");
    }
}


