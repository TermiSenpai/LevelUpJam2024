using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradePanel : MonoBehaviour
{
    public List<Button> upgradeButtons;

    public void DisplayOptions(List<IUpgrade> options)
    {
        // Verifica que upgradeButtons no sea nulo y que tenga suficientes elementos
        if (upgradeButtons == null || upgradeButtons.Count == 0)
        {
            Debug.LogError("Upgrade buttons are not assigned in UpgradePanel.");
            return;
        }

        for (int i = 0; i < options.Count; i++)
        {
            // Verifica si el índice está dentro del rango de upgradeButtons
            if (i < upgradeButtons.Count && upgradeButtons[i] != null)
            {
                upgradeButtons[i].gameObject.SetActive(true);
                upgradeButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = options[i].Name;
                int index = i;
                upgradeButtons[i].onClick.AddListener(() => SelectUpgrade(options[index]));
            }
            else
            {
                Debug.LogError($"Upgrade button at index {i} is not properly assigned.");
            }
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
