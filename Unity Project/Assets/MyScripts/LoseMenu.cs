using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{
    public GameObject playButton;
    public GameObject QuitButton;

    // Assign the PlayButton GameObject in the Unity Editor

    private void Start()
    {
        Time.timeScale = 1f;

        // Check if playButton is assigned before setting it as the selected GameObject
        if (playButton != null)
        {
            EventSystem.current.SetSelectedGameObject(playButton);
        }
        else
        {
            Debug.LogWarning("PlayButton GameObject is not assigned in the MainMenu script.");
        }

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("Start was called");
    }

    public void PlayGame()
    {
        Debug.Log("Play pressed");
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        Debug.Log("Quit pressed");
        Application.Quit();
    }
}
