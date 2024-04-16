using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float timeBetweenWaves = 5.0f;
    public int waveCount;

    public bool waveIsDone = true;

    public GameObject ufoWave;

    private void Update()
    {
        if (waveIsDone == true)
        {
            StartCoroutine(Spawner());
        }
    }

    IEnumerator Spawner()
    {
        waveIsDone = false;

        for (int i = 0; i < 1; i++)
        {
            UImanager.ufoCount += 10;
            UfoMovement.hasHitBottomScreen = false;

            Instantiate(ufoWave);
            print("ufocount" + UImanager.ufoCount);
        }

        yield return new WaitForSeconds(timeBetweenWaves);

        waveIsDone = true;
    }
}
