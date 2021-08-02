using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFinishColor : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
}
