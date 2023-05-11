using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<Waypoints> waypoints = new List<Waypoints>();
    [SerializeField] float waitingTime;
    [SerializeField] [Range(0f, 5f)] float enemySpeed;

    EnemyDrop enemyPenalty;
    void Start()
    {
        enemyPenalty = FindObjectOfType<EnemyDrop>();    
    }

    void OnEnable()
    {
        FindingPath();
        ReturnToStart();
        StartCoroutine(FollowingPath());
    }
  

    void FindingPath()
    {
        waypoints.Clear();
        GameObject parent = GameObject.FindGameObjectWithTag("Path");

        foreach (Transform item in parent.transform)
        {
            waypoints.Add(item.GetComponent<Waypoints>());
        }
    }

    void ReturnToStart()
    {
        transform.position = waypoints[0].transform.position;
    }

    IEnumerator FollowingPath() {
        foreach (var item in waypoints)
        {
            Vector3 startPos = transform.position;
            Vector3 endPos = item.transform.position;
            float movePercent = 0f;
            
            transform.LookAt(endPos);

            while (movePercent < 1f)
            {
                movePercent += Time.deltaTime * enemySpeed;
                transform.position = Vector3.Lerp(startPos, endPos, movePercent);
                yield return new WaitForEndOfFrame();
            }
        }
        enemyPenalty.PenaltyHealth();
        gameObject.SetActive(false);
    }
}
