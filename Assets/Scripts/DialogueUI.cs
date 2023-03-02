using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private DialogueObject testDialogue;
    [SerializeField] private Button nextButton;

    private bool goNext = false;


    private TypewriterEffect typewriterEffect;

    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (!GameControl.control.loadedScenes.Contains(sceneName))
        {
            Time.timeScale = 0;
            typewriterEffect = GetComponent<TypewriterEffect>();
            CloseDialogueBox();
            ShowDialogue(testDialogue);
            nextButton.onClick.AddListener(SwitchToTrue);
            GameControl.control.loadedScenes.Add(sceneName);
        }
        else
        {
            CloseDialogueBox();
        }
    }

    void SwitchToTrue()
    {
        goNext = true;
    }
    public void ShowDialogue(DialogueObject dialogueObject)
    {
        dialogueBox.SetActive(true);
        StartCoroutine(StepThroughDialogue(dialogueObject));
    }
    private IEnumerator StepThroughDialogue(DialogueObject dialogueObject)
    {

        foreach (string dialogue in dialogueObject.Dialogue)
        {
            yield return typewriterEffect.Run(dialogue, textLabel);
            yield return new WaitUntil(() => goNext);
            goNext = false;
        }

        CloseDialogueBox();
        Time.timeScale = 1;
    }

    private void CloseDialogueBox()
    {
        dialogueBox.SetActive(false);
        textLabel.text = string.Empty;
    }

}
