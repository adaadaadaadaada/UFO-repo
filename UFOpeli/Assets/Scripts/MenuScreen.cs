using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScreen : MonoBehaviour
{
    public GameObject background;
    public GameObject instructionsScreen;
    public GameObject creditsScreen;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            instructionsScreen.SetActive(false);
            background.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            creditsScreen.SetActive(false);
            background.SetActive(true);
        }
    }

    public void instructionsButton()
    {
        background.SetActive(false);
        creditsScreen.SetActive(false);
        instructionsScreen.SetActive(true);
    }

    public void creditsButton()
    {
        background.SetActive(false);
        creditsScreen.SetActive(false);
        creditsScreen.SetActive(true);
    }

    public void startButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void quitButton()
    {
        Application.Quit();
    }
}
