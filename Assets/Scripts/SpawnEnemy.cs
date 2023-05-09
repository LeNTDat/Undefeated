using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float spawnRepeatTime = 2f;
    [SerializeField] int poolSize = 5;

    GameObject[] pool;

     void Awake()
    {
        SpawnEnemyInPool();
    }

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    void SpawnEnemyInPool ()
    {
        pool = new GameObject[poolSize];

        for(int i = 0; i < pool.Length; i++)
        {
            pool[i] = Instantiate(enemy, transform.position, Quaternion.identity);
            pool[i].SetActive(false);
        }
    }

    void EnableObjInPool()
    {
        foreach (var item in pool)
        {
            if (item.activeSelf == false) {
                item.SetActive(true);
                return;
            }
        }
    } 

    IEnumerator SpawnEnemies()
    {
       while (true) { 
            EnableObjInPool();
            yield return new WaitForSeconds(spawnRepeatTime);
        }

    }
}
