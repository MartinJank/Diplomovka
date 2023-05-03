using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Promote : MonoBehaviour
{

    void Start()
    {
        if (GameControl.control.exp >= GameControl.control.levelOfEarning * 50 + 50)
        {
            GameControl.control.levelOfEarning++;
        }
    }

}
