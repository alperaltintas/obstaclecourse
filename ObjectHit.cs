using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Bir şey çarptı.");
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().material.color = Color.red;

            gameObject.tag = "Hit";

        }


    }
}
