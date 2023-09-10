using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    float score = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "hitted")
        {
            score += 1;
            other.gameObject.tag = "hitted";
            Debug.Log("You have bunmped into the thing this many times: " + score);
        }
        else
        {
            Debug.Log("You have bunmped into the thing this many times: " + score);
        }
    }

}
