using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseController : MonoBehaviour
{
    // Start is called before the first frame update

    


    public bool GameIsLost;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            Debug.Log("You Lose");


            SceneManager.LoadScene("LoseMenu");

            // GameManager.GameIsLost = true;

            // GameManager.OnGameIsLost();

           

        }

    }
}
