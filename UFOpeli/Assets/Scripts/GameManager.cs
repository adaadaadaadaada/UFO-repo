using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public AudioSource src;
    public AudioClip scoreSFX;

    public GameObject loseScreen;
    public Health health;

    public UImanager uimanager;
    public GameObject winScreen;

    private void Start()
    {
    }

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
        Screen.SetResolution(500, 500, false);
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
