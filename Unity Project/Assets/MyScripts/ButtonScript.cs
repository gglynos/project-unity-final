using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Button resetButton;
    public void Start()
    {
        
        gameObject.SetActive(true);
        // Add a listener to the button
        resetButton.onClick.AddListener(UI_ResetButtonClicked);

        resetButton.interactable = false;
    }

    public void UI_ResetButtonActive()
    {
        gameObject.SetActive(true);
        resetButton.interactable = true;

        

    }



    public void UI_ResetButtonClicked()
    {
        // Write your function logic here
        


        Debug.Log("Button pressed!");
       // GameManager.OnGameIsReset();

    }
}
