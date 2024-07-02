public class IceBulletUpgrade : Upgrade
{
    public override string Name => "Ice Bullets";

    public override void Apply(PlayerUpgrades player)
    {
        player.SetBulletType(typeof(IceBullet));
    }

    public override void ApplyOnShoot(IBullet bullet)
    {
        if (bullet is IceBullet iceBullet)
        {
            // Configurar el efecto de ralentización si es necesario
        }
    }
}

// Similar para otras mejoras...
