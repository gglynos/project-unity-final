using DoorScript;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject PauseMenu;

    public AudioSource audioSource;

    private bool menuActivated;

    void Start()
    {
        audioSource = GameObject.Find("CameraController").GetComponent<AudioSource>();

        

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P) && menuActivated)


        {
            Time.timeScale = 1;

            PauseMenu.SetActive(false);
            menuActivated = false;
            GameManager.LockMouse();

            audioSource.pitch = 1;

        }

        else if (Input.GetKeyDown(KeyCode.P) && !menuActivated)


        {

             Time.timeScale = 0;

            PauseMenu.SetActive(true);
            menuActivated = true;
            GameManager.UnlockMouse();

            audioSource.pitch = 0.5f;

        }


    }
}
