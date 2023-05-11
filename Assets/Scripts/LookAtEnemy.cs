using System.Collections.Generic;
using UnityEngine;

public class LookAtEnemy : MonoBehaviour
{
    Transform enemy;
    [SerializeField] Transform turret;
    [SerializeField] GameObject bullet;
    ParticleSystem.EmissionModule emission ;
    float MaxRange = 10f;
    


    void Start()
    {
        emission = bullet.GetComponent<ParticleSystem>().emission;
    }
    void Update()
    {
        FindClosetEnemt();
        AIlocator();
    }

    void FindClosetEnemt() {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        Transform closetEnemy = null;
        float MaxDistance = Mathf.Infinity;

        foreach (var item in enemies)
        {
            float TargetDistance = Vector3.Distance(transform.position, item.transform.position);
            if(TargetDistance < MaxDistance)
            {
                closetEnemy = item.transform;
                MaxDistance = TargetDistance;
            }
        }
        enemy = closetEnemy;
    }

    void AIlocator()
    {
            float TargetDistance = Vector3.Distance(transform.position, enemy.position);
            turret.LookAt(enemy);
            if (TargetDistance < MaxRange) {
                AttckController(true);
            }
            else
            {
                AttckController(false);
            }
            bullet.transform.LookAt(enemy);
    }

    void AttckController(bool isActive)
    {
        emission.enabled = isActive;
    }
}
