using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    /// <summary>
    /// check for whenever 10 ufos get shot
    /// & check for whenever 10 ufos collide with the bottom screen
    /// </summary>
    /// 

    public Health health;

    public static int ufoCount;
    public static int ufosShot;
    public static int score = 0;
    Text scoreText;

    private void Start()
    {
        scoreText = GetComponent<Text>();
    }

    private void Update()
    {
        scoreText.text = "Score: " + score;
    }
}
