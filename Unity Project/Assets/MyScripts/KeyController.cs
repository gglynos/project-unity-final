using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keyController : MonoBehaviour

{
    

    

    public bool keyIsTaken;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            Debug.Log("Key is taken");
            GameManager.keyIsTaken = true;

            GameManager.OnKeyFound();

            gameObject.SetActive(false);

            

        }

    }
}
