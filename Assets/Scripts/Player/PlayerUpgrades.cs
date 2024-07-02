using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerUpgrades : MonoBehaviour
{
    private List<IUpgrade> activeUpgrades = new List<IUpgrade>();
    private IBullet currentBullet;
    public int level;
    public List<IUpgrade> availableUpgrades;
    public GameObject upgradePanel;

    public void SetBulletType(Type bulletType)
    {
        currentBullet = (IBullet)Activator.CreateInstance(bulletType);
    }

    public void LevelUp()
    {
        level++;
        ShowUpgradeOptions();
    }

    private void ShowUpgradeOptions()
    {
        List<IUpgrade> options = new List<IUpgrade>();
        for (int i = 0; i < 3; i++)
        {
            int index = UnityEngine.Random.Range(0, availableUpgrades.Count);
            options.Add(availableUpgrades[index]);
        }
        upgradePanel.GetComponent<UpgradePanel>().DisplayOptions(options);
    }

    public void ApplyUpgrade(IUpgrade upgrade)
    {
        activeUpgrades.Add(upgrade);
        upgrade.Apply(this);
    }

    public void Shoot()
    {
        foreach (var upgrade in activeUpgrades)
        {
            upgrade.ApplyOnShoot(currentBullet);
        }
        currentBullet.Shoot();
    }
}
