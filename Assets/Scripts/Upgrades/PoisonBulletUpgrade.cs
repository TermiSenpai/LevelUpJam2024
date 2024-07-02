public class PoisonBulletUpgrade : Upgrade
{
    public override string Name => "Poison Bullets";

    public override void Apply(PlayerUpgrades player)
    {
        player.SetBulletType(typeof(PoisonBullet));
    }

    public override void ApplyOnShoot(IBullet bullet)
    {
        if (bullet is PoisonBullet poisonBullet)
        {
            poisonBullet.AddOnHitEffect(damageable => {
                // Implementa aquí el efecto específico de veneno en el objeto damageable
                if (damageable is Enemy enemy)
                {
                    enemy.ApplyPoison(poisonBullet.poisonDamage); // Ejemplo hipotético de aplicación de veneno
                }
            });
        }
    }
}

// Similar para otras mejoras...
