using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int MaxHitPoint;
    int CurrentHitPoint;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        CurrentHitPoint = MaxHitPoint;
        animator = GetComponentInChildren<Animator>();
    }

    private void OnParticleCollision(GameObject other)
    {
        GetHitProcess();
        PlayDead();
    }

    void GetHitProcess()
    {
        CurrentHitPoint--;
        animator.Play("GetHit");
    }

    void PlayDead()
    {
        if (CurrentHitPoint < 1)
        {
            animator.Play("Die");
            Destroy(gameObject,1f);
        }
    }
}
