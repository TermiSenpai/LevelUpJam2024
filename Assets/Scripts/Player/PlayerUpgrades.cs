using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerUpgrades : MonoBehaviour
{
    [SerializeField] private List<IUpgrade> activeUpgrades = new List<IUpgrade>();
    private Bullet currentBullet;
    public int level;
    public List<IUpgrade> availableUpgrades;
    public GameObject upgradePanel;

    private void Start()
    {
        // Ejemplo de inicialización de availableUpgrades
        availableUpgrades = new List<IUpgrade>
        {
            new PoisonBulletUpgrade(), // Ejemplo de agregar una mejora
            new IceBulletUpgrade() // Ejemplo de agregar otra mejora
        };

        LevelUp(); // Llama a LevelUp() después de inicializar availableUpgrades
    }


    public void SetBulletType(Type bulletType)
    {
        currentBullet = (Bullet)gameObject.AddComponent(bulletType); // Añadir componente de bala dinámicamente
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
        //upgrade.Apply(currentBullet);
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
