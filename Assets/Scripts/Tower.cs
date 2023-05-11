using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] int price = 75;
    Bank bank;

    public bool CreateTower(Tower PreFabTower, Vector3 position)
    {
        bank = FindAnyObjectByType<Bank>();

        if (bank == null) { 
            return false;
        }

        if (bank.CurrentBalance >= price)
        {
            bank.Withdrawal(price);
            Instantiate(PreFabTower.gameObject, new Vector3(position.x, transform.position.y, position.z), Quaternion.identity);
            return true;
        }
        return false;

    }
}
