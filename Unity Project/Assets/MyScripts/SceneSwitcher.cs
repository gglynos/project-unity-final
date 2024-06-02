using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public float delayTime = 1f;

    private ThirdPersonController player;

    public AudioClip burnfx;
    public AudioSource asource;

    void Start()
    {
        asource = GetComponent<AudioSource>();
    }


    // Specify the name of the scene to load in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Replace "Player" with the tag of the object that triggers the scene switch
        {
            

            player = FindObjectOfType<ThirdPersonController>();

            player.gravity = 1f;

            asource.clip = burnfx;
            asource.Play();


            GameManager.GameIsLost = true;

            GameManager.OnGameIsLost();
           

            StartCoroutine(LoadSceneAfterDelay());
        }

         IEnumerator LoadSceneAfterDelay()
        {
            // Wait for the specified delay time
            yield return new WaitForSeconds(delayTime);
             
            // Load the scene
            SceneManager.LoadScene("LoseMenu");
        }
    }

}
