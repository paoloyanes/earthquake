using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoBackMainMenu()
    {
        StateNameController.selectStartingLocationDropdown = 0;
        SceneManager.LoadScene("Menu");
    }
}
