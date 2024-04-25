using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UImanager : MonoBehaviour
{
    /// <summary>
    /// check for whenever 10 ufos get shot
    /// & check for whenever 10 ufos collide with the bottom screen
    /// </summary>
    /// 

    public TMP_Text scoreText;
    public Health health;

    public static int ufoCount;
    public static int ufosShot;
    public int score = 0;

    private void Start()
    {
        scoreText = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        scoreText.text = "Score: " + score + "     HighScore: " +  PlayerPrefs.GetInt("HighScore");
        CheckHighScore();
    }

    void CheckHighScore()
    {
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
