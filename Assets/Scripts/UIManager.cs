using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject gameOverPanel;

    [SerializeField] private TextMeshProUGUI animalFedText;
    [SerializeField] private TextMeshProUGUI animalFed2Text;

    [SerializeField] private Button continueButton;
    [SerializeField] private Button restartPauseButton;
    [SerializeField] private Button level1Button;
    [SerializeField] private Button level2Button;
    [SerializeField] private Button restartGOButton;

    private GameManager gameManagerScript;

    void Start()
    {
        gameManagerScript = FindObjectOfType<GameManager>();

        restartPauseButton.onClick.AddListener(() => { gameManagerScript.RestartGameScene(); });
        restartGOButton.onClick.AddListener(() => { gameManagerScript.RestartGameScene(); });
        continueButton.onClick.AddListener(() => { gameManagerScript.ResumeGame(); });
        level1Button.onClick.AddListener(() => { gameManagerScript.SelectLevel(true); });
        level2Button.onClick.AddListener(() => { gameManagerScript.SelectLevel(false); });
    }

    public void ShowMainMenuPanel()
    {
        Time.timeScale = 0;
        mainMenuPanel.SetActive(true);
        animalFed2Text.text = "";
    }

    public void HideMainMenuPanel()
    {
        Time.timeScale = 1;
        mainMenuPanel.SetActive(false);
    }

    public void ShowPausePanel()
    {
        pausePanel.SetActive(true);
    }

    public void HidePausePanel()
    {
        pausePanel.SetActive(false);
    }

    public void ShowGameOverPanel(int animalsFed)
    {
        animalFedText.text = "Animals fed: " + animalsFed;
        gameOverPanel.SetActive(true);
        animalFed2Text.text = "";
    }

    public void HideGameOverPanel()
    {
        gameOverPanel.SetActive(false);
    }

    public void UpdateFed(int animalsFed)
    {
        animalFed2Text.text = "Animals Fed = " + animalsFed;
    }

}
