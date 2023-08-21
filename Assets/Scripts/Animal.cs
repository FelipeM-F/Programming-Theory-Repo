using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public GameObject food;
    public float speed = 20.0f;
    public float stoppingDistance = .01f;
    private void Start()
    {
        
    }

    private void Update()
    {
        FindFood();
        MoveTowardsFood();
    }

    public void MoveTowardsFood()
    {
        if (food != null)
        {
            Vector3 lookDirection = food.transform.position - transform.position;

            // Se a distância for maior que a distância de parada, continue movendo
            if (lookDirection.magnitude > stoppingDistance)
            {
                Vector3 moveDirection = lookDirection.normalized;
                transform.position += moveDirection * speed * Time.deltaTime;
            }
        }
    }


    public virtual void FindFood()
    {
        food = GameObject.FindWithTag("Food");
    }

 
}
