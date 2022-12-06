using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateMoneyUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI displayMoney;
    void Start()
    {
        int money = GameControl.control.money;
        displayMoney.text = "Money: " + money;
    }
}
