using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] patterns;

    private float spawnTime;
    [SerializeField] private float spawnRate;
    [SerializeField] private float spawnRateMin;

    [SerializeField] private float rampUp;

    private void Update()
    {
        if (spawnTime <= 0)
        {
            int pat = Random.Range(0, patterns.Length);
            Instantiate(patterns[pat], transform.position, Quaternion.identity);

            spawnTime = spawnRate;
            if (spawnRate >= spawnRateMin)
            {
                spawnRate -= rampUp;
            }
        }
        else
        {
            spawnTime -= Time.deltaTime;
        }
    }
}
