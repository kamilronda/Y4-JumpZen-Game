using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public bool instructions;
    public GameObject instructionsScreen;

    /*public bool settings;
    public GameObject settingsScreen;*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        SceneManager.LoadScene("Jumpzen");
    }

    public void Menu()
    {
        SceneManager.LoadScene("IntroScreen");
    }

    public void settingsScene()
    {
        SceneManager.LoadScene("SettingsScreen");
    }

    public void instructionsFunction()
    {
        instructions = !instructions;
        instructionsScreen.SetActive(instructions);

        if(instructions)
        {
            Time.timeScale = 0;
        }else if(!instructions)
        {
            Time.timeScale = 1;
        }
    }

/*    public void settingsFunction()
    {
        settings = !settings;
        settingsScreen.SetActive(settings);

        if(settings)
        {
            Time.timeScale = 0;
        }
        else if (!settings)
        {
            Time.timeScale = 1;
        }
    }*/

    public void ExitGame()
    {
        Application.Quit();
    }
}
