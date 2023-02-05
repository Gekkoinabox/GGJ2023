using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI healthTxt;
    [SerializeField]
    TextMeshProUGUI scoreTxt;
    public bool win;

    public GameObject gameOverScreen;

    public int playerHealth = 3;
    public int playerScore = 0;

    private void Start()
    {
        gameOverScreen.SetActive(false);
        win = false;
        //DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        healthTxt.text = "health: " + playerHealth;
        scoreTxt.text = "score: " + playerScore;

        if (playerHealth == 0)
        {
            //gameOverScreen.SetActive(true);
            SceneManager.LoadScene("GameOver");
            Time.timeScale = 0;
        }
        if(win == true)
        {
            SceneManager.LoadScene("Win");
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
        
        SceneManager.LoadScene("Scene1");

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

    public void SetWin(bool input)
    {
        win = input;
    }
}
