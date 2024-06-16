using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform startPoint; 
    public Transform endPoint;  
    public float speed = 2.0f;

    private Vector3 direction;
                                          //vectores
    private Vector3 target;     

    void Start()
    {
        target = endPoint.position;
                                                                    
        direction = (target - transform.position).normalized; //Normalización
    }

    void Update()
    {
        MovePlatform();
    }

    void MovePlatform()
    {
        float distanceToTarget = Vector3.Distance(transform.position, target);   //Magnitud

        if (distanceToTarget < 0.1f)
        {
            target = target == endPoint.position ? startPoint.position : endPoint.position; //Comparación de vectores

            direction = (target - transform.position).normalized; //Aritmética básica
        }

        transform.position += direction * speed * Time.deltaTime; //Aritmética básica 
    }
}