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

        //uiView.SetCondition("Find the key and exit");
    }

    public static void OnKeyFound()
    {
        keyIsTaken = true;
        uiView.SetCondition("You found the treasure, now find the exit");
    }

    public static void OnGoalReached()
    {
        if (keyIsTaken)
        {
            uiView.SetCondition("Congratulations, You Won");

            

            Time.timeScale = 0.5f;

            // Start the coroutine to load the scene with a delay
            GameManager instance = FindObjectOfType<GameManager>();
            instance.StartCoroutine(instance.LoadSceneWithDelay());

        }
        else
        {
            Debug.Log("collided with goal");

            
        }
    }

    private IEnumerator LoadSceneWithDelay()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MainMenu");
    }



    public static void OnGoalWithoutTreasure()
    {

        uiView.SetCondition("Look for the treasure first");
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
