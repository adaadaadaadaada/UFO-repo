using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    /// <summary>
    /// check for whenever 10 ufos get shot
    /// & check for whenever 10 ufos collide with the bottom screen
    /// </summary>
    /// 

    public static int ufoCount;
    public static int ufosShot;
    public static int ufosMissed;

    private void Update()
    {
        print(ufosMissed);
    }

}
