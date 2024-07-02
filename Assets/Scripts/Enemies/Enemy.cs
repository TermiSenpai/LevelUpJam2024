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
        // L�gica para la muerte del enemigo
    }

    public void ApplyPoison(float poisonDamage)
    {
        // L�gica para aplicar veneno
    }

    public void ApplySlow(float slowAmount, float duration)
    {
        // L�gica para aplicar el efecto de ralentizaci�n
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
        // L�gica para destruir el objeto
    }
}
