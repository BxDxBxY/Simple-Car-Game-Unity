using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody body;
    [SerializeField] float currentTime = Time.time;
    [SerializeField] float timeToWait = 3f;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        body = GetComponent<Rigidbody>();
        renderer.enabled = false;
        body.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            body.useGravity = true;
            renderer.enabled = true;

        }
    }
}
