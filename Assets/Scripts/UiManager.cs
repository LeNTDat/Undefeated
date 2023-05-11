using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] TMP_Text baseHealth;
    [SerializeField] TMP_Text currentHealth;
    PlayerHealth health;

    void Start()
    {
        health = FindObjectOfType<PlayerHealth>();
        baseHealth.text = health.BaseHealth.ToString();
    }

    void Update()
    {
        DisplayCurrentHealth();
    }

    void DisplayCurrentHealth ()
    {
        currentHealth.text = health.CurrentHealth.ToString();
    }


}
