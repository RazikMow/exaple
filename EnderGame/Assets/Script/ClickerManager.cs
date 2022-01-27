using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerManager : MonoBehaviour
{
    [SerializeField] public ClickerUI clickerUI;
    [SerializeField] public Button clickerButton;

    private int pointsCounter = 0;

    private void Start()
    {
        clickerUI.UpdateUI(pointsCounter);
        clickerButton.onClick.AddListener(AddPoints);
    }

    private void AddPoints()
    {
        pointsCounter += 1;
        clickerUI.UpdateUI(pointsCounter);
    }
}
