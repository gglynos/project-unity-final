using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDirections : MonoBehaviour
{
    // Start is called before the first frame update


    public UiView uiView;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            Debug.Log("You Lose");


            uiView.SetCondition("Press F to call the Transporter");



        }

    }
    private void OnTriggerExit(Collider other)
    {
       

            Debug.Log("exited instructions");


            uiView.SetCondition(" ");



        

    }
}
