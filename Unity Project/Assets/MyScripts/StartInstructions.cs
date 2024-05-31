using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartInstructions : MonoBehaviour
{
    // Start is called before the first frame update


    public UiView uiView;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

           


            uiView.SetCondition("Find the key and exit. Press Shift to run.");



        }

    }
    private void OnTriggerExit(Collider other)
    {
       

            Debug.Log("exited instructions");


            uiView.SetCondition(" ");



        

    }
}
