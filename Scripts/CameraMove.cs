using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;

    public Vector3 offeset;
   

    
    void Update()
    {
        if (player != null)
        {
            Vector3 camPos = transform.position;
            Vector3 desiredPos = player.transform.position;

           

            transform.position = new Vector3(transform.position.x, desiredPos.y + 3, transform.position.z);
        }
    }
}
