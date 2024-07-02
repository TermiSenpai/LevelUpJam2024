using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradePanel : MonoBehaviour
{
    public List<Button> upgradeButtons;

    public void DisplayOptions(List<IUpgrade> options)
    {
        for (int i = 0; i < options.Count; i++)
        {
            upgradeButtons[i].GetComponentInChildren<Text>().text = options[i].Name;
            int index = i;
            upgradeButtons[i].onClick.AddListener(() => SelectUpgrade(options[index]));
        }
    }

    private void SelectUpgrade(IUpgrade upgrade)
    {
        FindObjectOfType<PlayerUpgrades>().ApplyUpgrade(upgrade);
        Hide();
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
