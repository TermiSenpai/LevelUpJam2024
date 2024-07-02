using System.Collections.Generic;
using System;
using UnityEngine;

public abstract class Bullet : MonoBehaviour, IBullet
{
    public float damage;
    public float speed;

    private List<Action<IDamageable>> onHitEffects = new List<Action<IDamageable>>();

    public abstract void Shoot();

    public void AddOnHitEffect(Action<IDamageable> effect)
    {
        onHitEffects.Add(effect);
    }

    public void Hit(IDamageable damageable)
    {
        damageable.TakeDamage(damage);
        foreach (var effect in onHitEffects)
        {
            effect(damageable);
        }
    }
}

// Similar para BombBullet, BiggerBullet, SmallerFastBullet...
