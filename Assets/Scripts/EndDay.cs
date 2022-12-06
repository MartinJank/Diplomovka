using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndDay : MonoBehaviour
{
    [SerializeField] private string playerTag;
    [SerializeField] private bool triggerActive = false;
    [SerializeField] private GameObject uiPanel;
    [SerializeField] private string scene;

    private void OnTriggerEnter2D(Collider2D otherObject) {
        
        // int money = --GameControl.control.money;

        // Debug.Log("Money: " + money);
        // GameControl.control.isExhausted = false;

        if (otherObject.CompareTag(playerTag))
        {
            triggerActive = true;
            uiPanel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D otherObject) {

        if (otherObject.CompareTag(playerTag))
        {
            triggerActive = false;
            uiPanel.SetActive(false);
        }
    }

    private void Update()
    {
        if (triggerActive && Input.GetKeyDown(KeyCode.Space))
        {
            CharacterSleep();
        }
    }

    public void CharacterSleep()
    {
        int money = --GameControl.control.money;

        Debug.Log("Money: " + money);
        GameControl.control.isExhausted = false;
        SceneManager.LoadScene(scene);

    }

}
