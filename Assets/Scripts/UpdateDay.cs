using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateDay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI displayDay;
    void Start()
    {
        displayDay.text = "Day: " + GameControl.control.day;
    }
}
