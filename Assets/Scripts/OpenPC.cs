using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPC : MonoBehaviour
{
    [SerializeField] private string playerTag;
    [SerializeField] private bool triggerActive = false;
    [SerializeField] private GameObject uiPanel;

    private void OnTriggerEnter2D(Collider2D otherObject)
    {

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
            OpenPCdialogue();
        }
    }
    public void OpenPCdialogue()
    {
        
    }
}
