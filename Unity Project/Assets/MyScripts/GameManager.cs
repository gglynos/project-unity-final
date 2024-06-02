using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    
    public static bool keyIsTaken = false;

    public static bool GameIsLost = false;

    public static UiView uiView;

    public static ButtonScript resetButton;


    public float delayTime = 1f;









    private void Start()
    {
        uiView = FindObjectOfType<UiView>();

        resetButton = FindObjectOfType<ButtonScript>();

        UnityEngine.Cursor.lockState = CursorLockMode.None;

        
    }

    public static void OnKeyFound()
    {
        
        uiView.SetCondition("You found the treasure, now find the exit");
    }

    public static void OnGoalReached()
    {
        if (keyIsTaken)
        {
            uiView.SetCondition("Congratulations, You Won");

            

            

            // Start the coroutine to load the scene with a delay
            GameManager instance = FindObjectOfType<GameManager>();
            instance.StartCoroutine(instance.LoadSceneWithDelay());

        }
        else
        {
            Debug.Log("collided with goal");
            uiView.SetCondition("Look for the treasure first");

        }
    }

    private IEnumerator LoadSceneWithDelay()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MainMenu");
    }



    




    public static void OnGameIsLost()
    {

        

        if (GameIsLost) 
        {
            uiView.SetCondition("Too Bad, You Lost");




        }


    }


    public static void LockMouse()
    {

        UnityEngine.Cursor.visible = false;
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;

    }

    public static void UnlockMouse()
    {

        UnityEngine.Cursor.visible = true;
        UnityEngine.Cursor.lockState = CursorLockMode.None;

        

    }










}
