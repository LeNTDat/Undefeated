using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int health = 100;
    [SerializeField] int currentHealth;
    [SerializeField] float healthShow;
    [SerializeField] GameObject SliderBar;

    Slider slider;
    public int BaseHealth { get { return health; } }
    public int CurrentHealth { get { return currentHealth; } }

    void Awake()
    {
        currentHealth = health;
        slider = SliderBar.GetComponent<Slider>();
        slider.maxValue = health;
    }

    void Update()
    {
        DisplayHealth();
    }

    void DisplayHealth ()
    {
        slider.value = currentHealth;
    }

    public void DecrementHealth(int amount)
    {
        currentHealth -= Mathf.Abs(amount);
    }

    public void IncrementHealth(int amount)
    {
        currentHealth += Mathf.Abs(amount);
    }
}
