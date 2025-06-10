using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Text healthText;

    private void Start()
    {
        playerHealth.onHealthChanged.AddListener(UpdateHealthUI);
        UpdateHealthUI(playerHealth.health);
    }

    void UpdateHealthUI(int currentHealth)
    {
        healthText.text = "Salud: " + currentHealth;
    }
}