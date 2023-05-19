using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowStats : MonoBehaviour
{

    [SerializeField] private TMP_Text label;
    // Start is called before the first frame update
    void Start()
    {
        label.text = "Money: "+ GameControl.control.money + "\nExperience: "+ GameControl.control.exp + "\nPočet povýšení: "+ GameControl.control.levelOfEarning + "\nPočet dosiahnutých dní: "+ GameControl.control.day;
    }
}
