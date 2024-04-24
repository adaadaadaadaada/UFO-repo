using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject loseScreen;
    public Health health;

    public UImanager uimanager;
    public GameObject winScreen;

    private void Update()
    {
        Setup();
        Win();
    }

    public void Setup()
    {
        if (health.currentHealth <= 0)
        {
            Time.timeScale = 0;
            
            loseScreen.SetActive(true);
        }
    }

    public void OKButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void Win()
    {
        if (uimanager.score >= 9999)
        {
            Time.timeScale = 0;
            winScreen.SetActive(true);
        }
    }
}
