public abstract class Upgrade : IUpgrade
{
    public abstract string Name { get; }
    public abstract void Apply(PlayerUpgrades player);

    public abstract void ApplyOnShoot(IBullet bullet);
}

// Similar para otras mejoras...
