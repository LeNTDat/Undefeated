using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int MaxHitPoint;
    int CurrentHitPoint;
    Animator animator;
    EnemyDrop enemyDrop;
    // Start is called before the first frame update
    void Start()
    {
        CurrentHitPoint = MaxHitPoint;
        animator = GetComponentInChildren<Animator>();
        enemyDrop = GetComponent<EnemyDrop>();
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
            enemyDrop.Drop();
            gameObject.SetActive(false);
            CurrentHitPoint = MaxHitPoint;
        }
    }
}
