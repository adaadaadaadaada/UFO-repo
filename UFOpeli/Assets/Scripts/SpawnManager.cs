using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{public float timeBetweenWaves = 5.0f;
    public int waveCount;

    public bool waveIsDone = true;

    public GameObject ufoWave;
    public int ufoCount;

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
            ufoCount = 10;
            Instantiate(ufoWave);
        }

        yield return new WaitForSeconds(timeBetweenWaves);

        waveIsDone = true;
    }
}