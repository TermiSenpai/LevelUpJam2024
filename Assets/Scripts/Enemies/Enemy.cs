using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    public float health;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Lógica para la muerte del enemigo
    }

    public void ApplyPoison(float poisonDamage)
    {
        // Lógica para aplicar veneno
    }

    public void ApplySlow(float slowAmount, float duration)
    {
        // Lógica para aplicar el efecto de ralentización
    }
}

public class DestructibleObject : MonoBehaviour, IDamageable
{
    public float durability;

    public void TakeDamage(float amount)
    {
        durability -= amount;
        if (durability <= 0)
        {
            Break();
        }
    }

    private void Break()
    {
        // Lógica para destruir el objeto
    }
}
