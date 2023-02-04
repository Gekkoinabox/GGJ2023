using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI healthTxt;

    public GameObject gameOverScreen;

    public int playerHealth = 3;

    private void Start()
    {
        gameOverScreen.SetActive(false);
    }

    private void Update()
    {
        healthTxt.text = "health: " + playerHealth;

        if (playerHealth == 0)
        {
            gameOverScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }

    // resets variables for next playthrough
    public void RefreshScene()
    {
        playerHealth = 3;
    }


    // logic for buttons 
    // when restart button is hit
    public void Restart()
    {
        
        SceneManager.LoadScene("SampleScene");

        RefreshScene();
        Time.timeScale = 1;

        // SceneManager.LoadScene("Garden");
        //RefreshScene();
    }

    public void Quit()
    {
        Debug.Log("player quit");
        Application.Quit();
    }
}
