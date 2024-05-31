using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using TMPro;


public class PauseMenu : MonoBehaviour
{
    public GameObject muteToggleButton; // Assign the PlayButton GameObject in the Unity Editor
    public GameObject QuitButton;

    public TMP_Text muteText;

    //private string defaultCondition = "MUTE";
    //private string unmuteCondition = "UNMUTE";


    private bool isMuted = false; // Variable to keep track of mute status

    private void Start()
    {


        // Check if playButton is assigned before setting it as the selected GameObject


        muteText.text = "MUTE";

        UpdateMuteButton();

    }

 

    public void ToggleMute()
    {

        if (AudioManager.Instance != null)
        {
            AudioManager.Instance.ToggleMute();

            

            UpdateMuteButton();
        }
    }

    public void QuitGame()
    {
        Debug.Log("Quit pressed");
        Application.Quit();
    }

    private void UpdateMuteButton()
    {
        if (AudioManager.Instance != null)
        {
            bool isMuted = AudioManager.Instance.IsMuted();

            muteText.text = isMuted ? "UNMUTE" : "MUTE";
            // Update the button text or icon to reflect the mute state if necessary
            Debug.Log("Mute Toggled: " + (isMuted ? "Muted" : "Unmuted"));
        }
    }



}
