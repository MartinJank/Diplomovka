using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeEverytingZero : MonoBehaviour
{
    // Start is called before the first frame update
    public void MakeZero()
    {
        GameControl.control.day = 1;
        GameControl.control.money = 100;
        GameControl.control.exp = 5;
        // GameControl.control.level = 5;
        GameControl.control.exp = 5;
        GameControl.control.loadedScenes.Clear();
    }
}
