using System.Collections.Generic;
using UnityEngine;

public class LookAtEnemy : MonoBehaviour
{
    Transform enemy;
    [SerializeField] List<Transform> target = new List<Transform>();
    [SerializeField] float XMax;
    [SerializeField] float ZMax;

    void Start()
    {
        enemy = FindObjectOfType<EnemyMovement>().transform;
    }
    void Update()
    {
        AIlocator();
    }

    void AIlocator()
    {
        foreach (var itemTransform in target)
        {
            itemTransform.transform.LookAt(enemy);
        }
    }
}
