using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EnterDoor : MonoBehaviour
{
    [SerializeField] private string playerTag;
    [SerializeField] private string scene;
    [SerializeField] private bool triggerActive = false;
    [SerializeField] private GameObject uiPanel;

    private void OnTriggerEnter2D(Collider2D otherObject)
    {
        // if (otherObject.gameObject.tag == playerTag)
        // {

            // if (scene == "Minigame" || scene == "Work")
            // {
            //     if (!GameControl.control.isExhausted)
            //     {
            //         GameControl.control.isExhausted = true;
            //         SceneManager.LoadScene(scene);
            //     }
            // }
            // else
            // {
            //     SceneManager.LoadScene(scene);
            // }

        // }

        if (otherObject.CompareTag(playerTag))
        {
            triggerActive = true;
            uiPanel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D otherObject) {
        if (otherObject.CompareTag("Player"))
        {
            triggerActive = false;
            uiPanel.SetActive(false);
        }
    }

    private void Update()
    {
        if (triggerActive && Input.GetKeyDown(KeyCode.Space))
        {
            OpenDoor();
        }
    }
    public void OpenDoor()
    {
        if (scene == "Minigame" || scene == "Work")
        {
            if (!GameControl.control.isExhausted)
            {
                GameControl.control.isExhausted = true;
                SceneManager.LoadScene(scene);
            }
        }
        else
        {
            SceneManager.LoadScene(scene);
        }
    }

}
