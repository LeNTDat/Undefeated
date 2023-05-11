using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bank : MonoBehaviour
{
    [SerializeField] TMP_Text coin;
    [SerializeField] int StartingBalance = 150;
    [SerializeField] int currentBalance;
    public int CurrentBalance { get { return currentBalance; } }

    void Awake()
    {
        currentBalance = StartingBalance;
    }

    void Update()
    {
        DisPlayCoint();
    }

    void DisPlayCoint()
    {
        coin.text = currentBalance.ToString();
    }

    public void Deposit(int amount)
    {
        currentBalance += Mathf.Abs(amount);
    }

    public void Withdrawal(int amount) { 
        currentBalance -= Mathf.Abs(amount);
    }
}
