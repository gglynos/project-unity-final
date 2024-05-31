using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockController : MonoBehaviour
{

    

    public bool doorIsInteractable = false;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            

        {

            doorIsInteractable = true;


            Debug.Log("collision detected");




        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")


        {

            doorIsInteractable = false;


            Debug.Log("collision detected");




        }
    }


}
