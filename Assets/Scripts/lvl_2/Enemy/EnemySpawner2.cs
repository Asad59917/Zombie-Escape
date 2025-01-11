using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner2 : MonoBehaviour
{
    [SerializeField]
    private GameObject EnemyPrefab;

    [SerializeField]
    private GameObject EnemyPrefab2;

    [SerializeField]
    private float MinimumSpawnTime;

    [SerializeField]
    private float MaxSpawnTime;

    private float TimeUntillSpawn;

    void Awake()
    {
        SetTimeUntillSpwan();
    }

    // Update is called once per frame
    void Update()
    {
        TimeUntillSpawn -= Time.deltaTime;

        if (TimeUntillSpawn <= 0 )
        {
            Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
            Instantiate(EnemyPrefab2, transform.position, Quaternion.identity);
            SetTimeUntillSpwan();
            SoundManager.instance.Spawnsound();
        }
    }
    private void SetTimeUntillSpwan()
    {
        TimeUntillSpawn = Random.Range(MinimumSpawnTime, MaxSpawnTime);
    }
}
