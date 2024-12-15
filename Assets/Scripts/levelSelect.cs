using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelSelect : MonoBehaviour
{

    public void LoadLevel1()
    {
        SceneManager.LoadScene("SampleScene"); // Replace "Level1" with the actual name of your first level
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Demo"); // Replace "Level2" with the actual name of your second level
    }
    public void Back()
    {
        SceneManager.LoadScene("MainMenu"); // Replace "Level2" with the actual name of your second level
    }
}
