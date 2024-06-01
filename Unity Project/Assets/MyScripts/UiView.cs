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

    



    public void SetCondition(string condition)
    {
        textObject.text = condition;
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
