using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject loseScreen;
    public Health health;

    private void Update()
    {
        Setup();
    }

    public void Setup()
    {
        print("playerhealth " + health.currentHealth);

        if (health.currentHealth <= 0)
        {
            loseScreen.SetActive(true);
        }
    }

    public void OKButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
