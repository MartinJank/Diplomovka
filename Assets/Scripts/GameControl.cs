using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static GameControl control;

    public int exp;
    public int money;
    public int day;
    public bool isExhausted;
    public bool homeSceneFirstLoad;

    private void Awake()
    {
        if (control == null)
        {
            control = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }
}
