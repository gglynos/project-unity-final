using DoorScript;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.LookDev;

[CreateAssetMenu]
public class ItemSO : ScriptableObject
{
    public string itemName;

    public DoorToUnlock doorToUnlock = new DoorToUnlock();

    public bool isLocked;

    public bool UseItem()
    { 
        if(doorToUnlock == DoorToUnlock.Door1)
        {

            if (GameObject.Find("Door1").GetComponent<DoorManager>().doorIsInteractable)
                
                {

                GameObject.Find("Door1").GetComponent<DoorManager>().OpenDoor();

                return true;
            }


            else return false;

            
        }

        if (doorToUnlock == DoorToUnlock.Door2)
        {

            if (GameObject.Find("Door2").GetComponent<DoorManager>().doorIsInteractable)

            {

                GameObject.Find("Door2").GetComponent<DoorManager>().OpenDoor();

                return true;
            }


            else return false;


        }

        if (doorToUnlock == DoorToUnlock.FinalDoor)
        {

            if (GameObject.Find("FinalDoor").GetComponent<DoorManager>().doorIsInteractable)

            {

                GameObject.Find("FinalDoor").GetComponent<DoorManager>().OpenDoor();

                return true;
            }


            else return false;


        }





        return false;

    }
        
    public enum DoorToUnlock
    {
        none, Door1, Door2, FinalDoor
    };
}
