using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiView : MonoBehaviour
{
    public TMP_Text textObject;

    private string defaultCondition = " ";
    private string foundKeyCondition = "You found the treasure, now exit";
    private string congratulationsCondition = "Congratulations,press Enter to play again";

    // A boolean variable to store the state of the button
      private bool buttonOn = false;

    private void Start()
    {
        SetCondition(defaultCondition);
    }

    public void Update()
    {
        // Check if the button is on
          if (buttonOn)
        {

            
            // Check if the user presses the Enter key
            if (Input.GetKeyDown(KeyCode.Return))
            {
                // Call the restartLevel() function
                restartLevel();
            }
        }  
    }



    public void SetCondition(string condition)
    {
        textObject.text = condition;
    }

    public void ToggleEndButton(bool on)
    {
        buttonOn = on;

        if (on)
        {
            Debug.Log("warning not implemented");

            
        }
    }   

    private void restartLevel()
    {
        int currentScene=SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

    public void OnKeyFound()
    {
        SetCondition(foundKeyCondition);
    }

    
    public void OnGoalReached()
    {
        SetCondition(congratulationsCondition);
    }
}
