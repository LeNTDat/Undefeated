using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<Waypoints> waypoints = new List<Waypoints>();
    [SerializeField] float waitingTime;
    [SerializeField] [Range(0f, 5f)] float enemySpeed;

    void Start()
    {
        StartCoroutine(FollowingPath());
    }

    IEnumerator FollowingPath() {
        foreach (var item in waypoints)
        {
            Vector3 startPos = transform.position;
            Vector3 endPos = item.transform.position;
            float movePercent = 0f;
            
            transform.LookAt(endPos);
            if(item == waypoints[(waypoints.Count - 1)])
            {
                GetComponentInChildren<Animator>().Play("IdleBattle");
            }

            while (movePercent < 1f)
            {
                movePercent += Time.deltaTime * enemySpeed;
                transform.position = Vector3.Lerp(startPos, endPos, movePercent);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
