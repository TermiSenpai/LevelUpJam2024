public interface IUpgrade
{
    string Name { get; }
    void Apply(PlayerUpgrades player);
    void ApplyOnShoot(IBullet bullet);
}
