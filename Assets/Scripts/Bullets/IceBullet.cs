public class IceBullet : Bullet
{
    public float slowAmount;
    public float slowDuration;

    public IceBullet()
    {
        AddOnHitEffect(damageable => {
            if (damageable is Enemy enemy)
            {
                enemy.ApplySlow(slowAmount, slowDuration);
            }
        });
    }

    public override void Shoot()
    {
        // Implementación del disparo
    }
}

// Similar para BombBullet, BiggerBullet, SmallerFastBullet...
