using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Speed at which player increases height
    public float speed = 20;
    //How many degrees roatate 
    private float rotationSpeed = 70;
    //Variables used in the cooldown method
    private bool isLeft = true;
    private bool coolDown = false;

    void Update()
    {
        
        //Moves the player upwards
        transform.Translate(Vector2.up * Time.deltaTime * speed);


        //Checks which way to rotate when space is clicked
        if(Input.GetKeyDown(KeyCode.Space) && isLeft && !coolDown)
        {
            transform.rotation *= Quaternion.Euler(0, 0, -rotationSpeed);

            StartCoroutine(leftChecker());

        }
        if(Input.GetKeyDown(KeyCode.Space) && !isLeft && !coolDown)
        {
            transform.rotation *= Quaternion.Euler(0, 0, rotationSpeed);

            StartCoroutine(rightChecker());
        }
    }

    //Checkers 
    IEnumerator leftChecker()
    {
        coolDown = true;
        yield return new WaitForSeconds(0.01f);
        isLeft = false;
        coolDown = false;
    }
    IEnumerator rightChecker()
    {
        coolDown = true;
        yield return new WaitForSeconds(0.01f);
        isLeft = true;
        coolDown = false;
    }
    
}
