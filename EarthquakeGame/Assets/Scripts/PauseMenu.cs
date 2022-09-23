using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                ContinueTheGame();
            }
            else
            {
                PauseTheGame();
            }
        }
    }

    public void ContinueTheGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void PauseTheGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Debug.Log("Loading menu...");
        //Time.timeScale = 1f; this might be not required
        //SceneManager.LoadScene(1);
    }

    public void ExitTheGame()
    {
        Debug.Log("Exiting the game...");
        Application.Quit();
    }
}
