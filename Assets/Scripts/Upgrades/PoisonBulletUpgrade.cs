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
            // Configurar el daño por veneno si es necesario
        }
    }
}

// Similar para otras mejoras...
