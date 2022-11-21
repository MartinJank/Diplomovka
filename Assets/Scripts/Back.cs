using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    [SerializeField] private string scene;

    public void Exit()
    {
        SceneManager.LoadScene(scene);
    }
}
