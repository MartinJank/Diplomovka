using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateExpUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI displayExp;
    void Start()
    {
        int exp = GameControl.control.exp;
        displayExp.text = "Experience: " + exp;
    }
}
