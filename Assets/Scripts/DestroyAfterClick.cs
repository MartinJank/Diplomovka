using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterClick : MonoBehaviour
{
    private void OnMouseDown() {

        if (gameObject.tag == "Corr")
        {
            GameControl.control.exp++;
            if (GameControl.control.exp % 50 == 0)
            {
                GameControl.control.levelOfEarning++;
            }
        }

        if (gameObject.tag == "Wrong")
        {
            GameControl.control.exp--;
        }

        Destroy(gameObject);
        Debug.Log("Clicked object");
    }
}
