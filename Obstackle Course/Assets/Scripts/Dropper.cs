using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] float timer = 4f;
    MeshRenderer renderer;
    Rigidbody rb;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>(); 
        renderer.enabled = false;
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        TimePassed();
    }

    void TimePassed()
    {
        if (Time.time > timer )
        {
            renderer.enabled = true;
            rb.useGravity = true;
        }

    }
}
