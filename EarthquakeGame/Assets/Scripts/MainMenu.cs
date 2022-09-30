using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public TMPro.TMP_Dropdown selectStartingLocation;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void DropdownSelectStartingLocation()
    {
        StateNameController.selectStartingLocationDropdown = selectStartingLocation.value;
    }

    public void ExitGame()
    {
        Debug.Log("Exiting the game...");
        Application.Quit();
    }
}
