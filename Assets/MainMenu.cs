using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour


{
    public GameObject mainMenuCanvas;
    public GameObject tutorialCanvas;


    public void StartGame()
    {
        SceneManager.LoadScene("MainGame"); // Load your game scene
    }

    public void OpenTutorial()
    {
        mainMenuCanvas.SetActive(false);
        tutorialCanvas.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit(); // This works for standalone builds
    }

    public void ShowTutorial()
    {
        
    }

    public void BackToMainMenu()
    {
        mainMenuCanvas.SetActive(true);
        tutorialCanvas.SetActive(false);
    }
}