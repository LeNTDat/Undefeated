using System.Collections.Generic;
using UnityEngine;

public class LookAtEnemy : MonoBehaviour
{
    Transform enemy;
    [SerializeField] List<Transform> turret = new List<Transform>();
    [SerializeField] float XMax;
    [SerializeField] float ZMax;

    void Start()
    {
        enemy = GameObject.FindWithTag("Enemy").transform;
    }
    void Update()
    {
        AIlocator();
    }

    void AIlocator()
    {
        foreach (var itemTransform in turret)
        {
            itemTransform.transform.LookAt(enemy);
        }
 
    }
}
