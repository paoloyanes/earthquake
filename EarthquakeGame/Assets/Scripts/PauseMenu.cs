using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject promptMessage;

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
        promptMessage.SetActive(true);
    }

    void PauseTheGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        promptMessage.SetActive(false);
    }

    public void LoadMenu()
    {
        //Debug.Log("Loading menu...");
        gameObject.SetActive(false);
        ContinueTheGame();
        promptMessage.SetActive(false);
        StateNameController.isStartGameClicked = false;
        SceneManager.LoadScene(0);
        //Time.timeScale = 1f; this might be not required
        //SceneManager.LoadScene(1);
    }

    public void ExitTheGame()
    {
        Debug.Log("Exiting the game...");
        Application.Quit();
    }
}
