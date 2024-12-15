using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        // Load the main game scene
        Debug.Log("Start Game clicked");
        SceneManager.LoadScene("SampleScene");
    }

    public void SelectLevel()
    {
        // Add logic for selecting levels if applicable
        Debug.Log("Select Level clicked");
        SceneManager.LoadScene("SelectLevel");
    }

    public void ExitGame()
    {
        // Quit the application (works in builds, not in the editor)
        Application.Quit();
    }
}

