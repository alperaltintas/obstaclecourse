using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Hit"))
        {
            score++;
            Debug.Log("Duvara vurulma sayısı =" + score);
        }
        
    }
}
