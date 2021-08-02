using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    [SerializeField] GameObject start, finish;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            start.GetComponent<MeshRenderer>().sharedMaterial.color = Color.green;
        }

    }

}
