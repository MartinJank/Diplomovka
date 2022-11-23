using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDay : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D otherObject) {
        int money = --GameControl.control.money;

        Debug.Log("Money: " + money);
    }
}
