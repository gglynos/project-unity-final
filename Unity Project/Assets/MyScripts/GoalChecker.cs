using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goalChecker : MonoBehaviour
{
    

    private keyController keyControllerScript;

    void Start()
    {
        // Find and store a reference to the keyController script
        keyControllerScript = FindObjectOfType<keyController>();

        if (keyControllerScript == null)
        {
            Debug.LogError("keyController script not found in the scene.");
        }
    }


    private void OnTriggerEnter(Collider other)
    {


        


        if (other.tag == "Goal" )
        {
            if (GameManager.keyIsTaken)
            {

                GameManager.OnGoalReached();
            }
            else
            {
                GameManager.OnGoalWithoutTreasure();
            }



        }

        

       
    }


}
