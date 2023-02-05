using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Uprooting");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartingScene");
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
