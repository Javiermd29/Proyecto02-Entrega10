using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int animalsFed;

    private DestroyOutOfBounds destroyScript;
    private PlayerController playerControllerScipt;
    private UIManager uiManager;

    void Start()
    {
        destroyScript = FindObjectOfType<DestroyOutOfBounds>();
        playerControllerScipt = FindObjectOfType<PlayerController>();
        uiManager = FindObjectOfType<UIManager>();

        uiManager.ShowMainMenuPanel();
        uiManager.HidePausePanel();
        uiManager.HideGameOverPanel();
        
    }

    private void Update()
    {
        PausePanel();
    }

    public void PausePanel()
    {
        if (Input.GetKeyDown("escape"))
        {
            uiManager.ShowPausePanel();
            Time.timeScale = 0;
        }
    }

    public void RestartGameScene()
    {

        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void ResumeGame()
    {
        uiManager.HidePausePanel();
        Time.timeScale = 1;
    }

    public void SelectLevel(bool level)
    {
        uiManager.HideMainMenuPanel();
        playerControllerScipt.level = level;
    }

    public void UpdateAnimalsFed()
    {
        uiManager.UpdateFed(animalsFed);
    }

}
