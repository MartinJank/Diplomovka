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

    private void OnTriggerEnter2D(Collider2D otherObject)
    {

        // int money = --GameControl.control.money;

        // Debug.Log("Money: " + money);
        // GameControl.control.isExhausted = false;

        if (otherObject.CompareTag(playerTag))
        {
            triggerActive = true;
            uiPanel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D otherObject)
    {

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
            int randTemp = Random.Range(0, 3);
            if (randTemp == 1)
            {
                Time.timeScale = 0;
                typewriterEffect = GetComponent<TypewriterEffect>();
                CloseDialogueBox();
                ShowDialogue(testDialogue);
                nextButton.onClick.AddListener(SwitchToTrue);
            }
            else
            {
                CloseDialogueBox();
                CharacterSleep();
            }
        }

        if (GameControl.control.day >= 20)
        {
            SceneManager.LoadScene("WinScreen");
        }
        if (GameControl.control.money < 0)
        {
            
            SceneManager.LoadScene("LooseScreen");
        }
    }

    public void CharacterSleep()
    {
        if (triggerActive) {
            GameControl.control.money -= 20;
            ++GameControl.control.day;

            Debug.Log("Money: " + GameControl.control.money);
            GameControl.control.isExhausted = false;
            SceneManager.LoadScene(scene);
        }

    }





    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private DialogueObject testDialogue;
    [SerializeField] private Button nextButton;

    private bool goNext = false;


    private TypewriterEffect typewriterEffect;

    void SwitchToTrue()
    {
        goNext = true;
    }
    public void ShowDialogue(DialogueObject dialogueObject)
    {
        dialogueBox.SetActive(true);
        Debug.Log("HEER1");
        StartCoroutine(StepThroughDialogue(dialogueObject));
    }
    private IEnumerator StepThroughDialogue(DialogueObject dialogueObject)
    {

        int tempLen = Random.Range(0, dialogueObject.Dialogue.Length);
        Debug.Log("dia" + dialogueObject.Dialogue.Length);

        yield return typewriterEffect.Run(dialogueObject.Dialogue[tempLen], textLabel);
        yield return new WaitUntil(() => goNext);
        goNext = false;

        // foreach (string dialogue in dialogueObject.Dialogue)
        // {
        //     Debug.Log("HEER2");
        //     yield return typewriterEffect.Run(dialogue, textLabel);
        //     yield return new WaitUntil(() => goNext);
        //     goNext = false;
        // }

        string s1 = dialogueObject.Dialogue[tempLen];
        int s2 = System.Int32.Parse(s1.Substring(s1.Length - 2));
        Debug.Log("cena: " + s2);
        GameControl.control.money -= s2;

        CloseDialogueBox();
        Time.timeScale = 1;
        CharacterSleep();
    }

    private void CloseDialogueBox()
    {
        dialogueBox.SetActive(false);
        textLabel.text = string.Empty;
    }


}
