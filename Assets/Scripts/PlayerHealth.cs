using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            TakeDamage(20);
        }
    }

    void TakeDamage(int damage)
    {

        currentHealth = currentHealth - damage;
        healthBar.SetHealth(currentHealth);
    }
}
