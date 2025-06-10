using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;

    [System.Serializable]
    public class HealthChangedEvent : UnityEvent<int> { }
    public HealthChangedEvent onHealthChanged;

    public void TakeDamage(int damage)
    {
        health -= damage;
        health = Mathf.Max(health, 0);
        onHealthChanged.Invoke(health);
    }

    public void Heal(int amount)
    {
        health += amount;
        onHealthChanged.Invoke(health);
    }
}