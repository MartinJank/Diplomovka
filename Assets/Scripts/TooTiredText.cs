using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooTiredText : MonoBehaviour
{
    [SerializeField] private string playerTag;
    [SerializeField] private bool triggerActive = false;
    [SerializeField] private GameObject uiText;

    private void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.CompareTag(playerTag))
        {
            triggerActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D otherObject)
    {
        if (otherObject.CompareTag(playerTag))
        {
            triggerActive = false;
            uiText.SetActive(false);
        }
    }

    private void Update()
    {
        if (triggerActive && Input.GetKeyDown(KeyCode.Space))
        {
            if (GameControl.control.isExhausted)
            {
                uiText.SetActive(true);
            }
        }
    }
}
