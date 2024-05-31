using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform platform;
    public Transform startPosition;
    public Transform endPosition;
    public float speed = 1.5f;

    int direction = 1;

     void Update()
    {
        Vector3 target = currentMovementTarget();

        platform.position = Vector3.Lerp(platform.position, target, speed * Time.deltaTime);

        float distance = (target - (Vector3)platform.position).magnitude;

        if (distance <= 0.1f) 
        {
            direction *= -1;
        }

        

    }

    Vector3 currentMovementTarget()
    {
        if (direction == 1)
        {
            return startPosition.position;
        }
        else
        {
            return endPosition.position;    
        }
    }


    

    



}
