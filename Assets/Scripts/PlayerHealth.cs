using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        if (currentHealth <= 0)
        {
            Debug.Log("Player died");

            // Réinitialiser la vie
            currentHealth = maxHealth;

            // Relancer la scène actuelle
            ReloadScene();
        }
    }

    private void ReloadScene()
    {
        // Charger à nouveau la scène actuelle
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
