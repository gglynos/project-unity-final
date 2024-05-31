using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    public float force = 10f;
    public float openHeight = 4.5f;
    public float duration = 1;
    bool elevatorOpen;
    Vector3 closePosition;
    void Start()
    {
        
        closePosition = transform.position;


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            OperateElevator();
        }
    }

  
    


    void OperateElevator()
    {
        StopAllCoroutines();
        if (!elevatorOpen)
        {
            Vector3 openPosition = closePosition + Vector3.up * openHeight;
            StartCoroutine(MoveElevator(openPosition));
        }
        else
        {
            StartCoroutine(MoveElevator(closePosition));
        }
        elevatorOpen = !elevatorOpen;
    }
    IEnumerator MoveElevator(Vector3 targetPosition)
    {
        float timeElapsed = 0;
        Vector3 startPosition = transform.position;
        while (timeElapsed < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, timeElapsed / duration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
    }

    // This function is called when the platform collides with another object
    void OnCollisionEnter(Collision collision)
    {
        // Check if the other object is the character
        if (collision.gameObject.tag == "Player")
        {

            Debug.Log("parenting player");

            // Parent the character to the platform
            collision.transform.SetParent(transform);
        }
    }

    // This function is called when the platform stops colliding with another object
    void OnCollisionExit(Collision collision)
    {
        // Check if the other object is the character
        if (collision.gameObject.tag == "Player")
        {

            Debug.Log("contacted Player");
            // Unparent the character from the platform
            collision.gameObject.transform.parent = null;
        }
    }



}
