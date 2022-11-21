using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExperiencePointsHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI displayExp;
    [SerializeField] private Animator anim;
    // private int exp = 0;
    public void Increment()
    {
        int exp = ++GameControl.control.exp;
        Debug.Log(exp);
        
        displayExp.text = "Experience: " + exp;
        anim.Play("Next page");
    }
}
