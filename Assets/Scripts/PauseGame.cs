using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private Button contButton;
    [SerializeField] private Button menuButton;
    [SerializeField] private GameObject dialogueBox;
    private bool isPaused = false;

    void Start()
    {
        isPaused = false;
    }

    void Update()
    {
        contButton.onClick.AddListener(ContinueGame);
        menuButton.onClick.AddListener(GoToMenu);
        if (Input.GetKeyDown("escape"))
        {
            if (isPaused) {
                dialogueBox.SetActive(false);
                Time.timeScale = 1;
                isPaused = false;
            } else {
                dialogueBox.SetActive(true);
                Time.timeScale = 0;
                isPaused = true;
            }

            print("esc key was pressed");
        }
    }

    void ContinueGame()
    {
        dialogueBox.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    void GoToMenu()
    {
        dialogueBox.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
        SceneManager.LoadScene("Menu scene");
    }
}
