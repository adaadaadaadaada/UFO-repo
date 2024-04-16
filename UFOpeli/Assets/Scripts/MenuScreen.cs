using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScreen : MonoBehaviour
{
    public GameObject background;
    public GameObject instructionsScreen;
    public GameObject creditsScreen;

    public void instructionsButton()
    {
        background.SetActive(false);
        instructionsScreen.SetActive(true);

        if (Input.GetKeyDown(KeyCode.Escape)) // ei toimi
        {
            instructionsScreen.SetActive(false);
        }
    }

    public void creditsButton()
    {
        background.SetActive(false);
        creditsScreen.SetActive(true);

        if (Input.GetKeyDown(KeyCode.Escape)) // ei toimi
        {
            creditsScreen.SetActive(false);
        }
    }
}
