public class PoisonBullet : Bullet
{
    public float poisonDamage;

    public PoisonBullet()
    {
        AddOnHitEffect(damageable => {
            if (damageable is Enemy enemy)
            {
                enemy.ApplyPoison(poisonDamage);
            }
        });
    }

    public override void Shoot()
    {
        // Implementación del disparo
    }
}

// Similar para BombBullet, BiggerBullet, SmallerFastBullet...
