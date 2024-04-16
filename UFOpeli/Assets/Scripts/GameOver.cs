using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject loseScreen;

    public void Setup(int score)
    {
        if (Healthbar.emptyHearts == true)
        {
            loseScreen.SetActive(true);
        }
    }

    public void OKButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
