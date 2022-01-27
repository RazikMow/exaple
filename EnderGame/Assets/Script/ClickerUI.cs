using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.Experimental;

public class ClickerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counterText;

    public void UpdateUI(int amount)
    {
        counterText.text = $"{amount}";
    }
}
