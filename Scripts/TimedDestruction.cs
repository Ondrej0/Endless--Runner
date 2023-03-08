using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestruction : MonoBehaviour
{
    public float timer = 7;

    void Awake()
    {
        Destroy(gameObject, timer);
    }

    
}
