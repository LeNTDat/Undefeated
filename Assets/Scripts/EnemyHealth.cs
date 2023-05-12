using UnityEngine;

[RequireComponent(typeof(EnemyDrop))]
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int MaxHitPoint;
    [SerializeField] int CurrentHitPoint;
    [SerializeField] int ChestDifficult = 1;
    Animator animator;
    EnemyDrop enemyDrop;
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
            MaxHitPoint += ChestDifficult;
            gameObject.SetActive(false);
            CurrentHitPoint = MaxHitPoint;
        }
    }
}
