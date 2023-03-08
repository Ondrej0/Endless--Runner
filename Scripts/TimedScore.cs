using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimedScore : MonoBehaviour
{
    //Text link
    public TextMeshProUGUI score;
    //Score reacurance 
    public float timeOfScore = 0f;
    //Score amount
    public float scoreAmount = 0f;
    //Bool check
    public bool checkTime = true;



    void Update()
    {
        if(checkTime)
        {
            score.text = scoreAmount.ToString();
            StartCoroutine(Timer());
        }
    }

    IEnumerator Timer()
    {
        checkTime = false;
        yield return new WaitForSeconds(timeOfScore);
        scoreAmount += 1;
        checkTime = true;
    }
}
