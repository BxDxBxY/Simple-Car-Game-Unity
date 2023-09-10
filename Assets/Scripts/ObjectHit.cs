using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer meshRenderer;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {
            // if (meshRenderer.material.color == Color.cyan)
            // {
            //     meshRenderer.material.color = Color.white;
            // }
            // else 
            meshRenderer.material.color = Color.cyan;
        }
    }
}
