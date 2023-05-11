using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDrop : MonoBehaviour
{
    [SerializeField] int GoldDrop = 10;
    [SerializeField] int HealthPenalty = 10;
    Bank bank;
    PlayerHealth health;

    void Start()
    {
        bank = FindObjectOfType<Bank>();
        health = FindObjectOfType<PlayerHealth>();
    }

    public void Drop() {
        bank.Deposit(GoldDrop);
    }

    public void PenaltyHealth()
    {
        health.DecrementHealth(HealthPenalty);
    }
}
