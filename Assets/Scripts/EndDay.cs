using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

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
            // int randTemp = Random.Range(0, 2);
            // if (randTemp == 1)
            // {
            //     Time.timeScale = 0;
            //     typewriterEffect = GetComponent<TypewriterEffect>();
            //     CloseDialogueBox();
            //     ShowDialogue(testDialogue);
            //     nextButton.onClick.AddListener(SwitchToTrue);
            // } else {
            //     CloseDialogueBox();
            // }
        }
    }

    public void CharacterSleep()
    {
        GameControl.control.money -= 20;
        ++GameControl.control.day;

        Debug.Log("Money: " + GameControl.control.money);
        GameControl.control.isExhausted = false;
        SceneManager.LoadScene(scene);

    }





   [SerializeField] private GameObject dialogueBox;
   [SerializeField] private TMP_Text textLabel;
   [SerializeField] private DialogueObject testDialogue;
   [SerializeField] private Button nextButton;

   private bool goNext = false;


   private TypewriterEffect typewriterEffect;

   void SwitchToTrue() {
        goNext = true;
   }
   public void ShowDialogue(DialogueObject dialogueObject) {
        dialogueBox.SetActive(true);
        Debug.Log("HEER1");
        StartCoroutine(StepThroughDialogue(dialogueObject));
   }
   private IEnumerator StepThroughDialogue(DialogueObject dialogueObject) {

        foreach (string dialogue in dialogueObject.Dialogue)
        {
            yield return typewriterEffect.Run(dialogue, textLabel);
            yield return new WaitUntil(() => goNext);
            goNext = false;
        }

        CloseDialogueBox();
        Time.timeScale = 1;
        Debug.Log("HEER2");
   }

    private void CloseDialogueBox() {
        dialogueBox.SetActive(false);
        textLabel.text = string.Empty;
    }


}
