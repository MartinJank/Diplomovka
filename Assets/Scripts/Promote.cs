using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Promote : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameControl.control.exp % 50 == 0)
        {
            GameControl.control.levelOfEarning++;
        }
    }

}
