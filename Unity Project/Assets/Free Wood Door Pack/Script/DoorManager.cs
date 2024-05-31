using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DoorScript
{
	[RequireComponent(typeof(AudioSource))]


public class DoorManager : MonoBehaviour {

        public bool doorIsInteractable; 
    //public bool isLocked;
	public bool open;
	public float smooth = 1.0f;
	float DoorOpenAngle = -90.0f;
    float DoorCloseAngle = 0.0f;
	public AudioSource asource;
	public AudioClip openDoor,closeDoor;
	// Use this for initialization
	void Start () {
		asource = GetComponent<AudioSource> ();
            //isLocked = false;
            doorIsInteractable = false;

    }
	
	// Update is called once per frame


       
	void Update () {

			if (Input.GetKeyDown(KeyCode.F)) OpenDoor();



        if (open)
		{
            var target = Quaternion.Euler (0, DoorOpenAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, target, Time.deltaTime * 5 * smooth);
	
		}
		else
		{
            var target1= Quaternion.Euler (0, DoorCloseAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, target1, Time.deltaTime * 5 * smooth);
	
		}  
	}



        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")


            {

                doorIsInteractable = true;


                

                Debug.Log("doorIsInteractable" + doorIsInteractable);


            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.tag == "Player")


            {

                 doorIsInteractable = false;
                Debug.Log("doorIsInteractable" + doorIsInteractable);
            }
        }

        public void OpenDoor(){
            if (doorIsInteractable) { 
            Debug.Log("open door was called");
		open =!open;
		asource.clip = open?openDoor:closeDoor;
		asource.Play ();
            }
        }
}
}