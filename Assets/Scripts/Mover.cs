using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        // PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xAxis = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zAxis = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xAxis, 0, zAxis);
    }
    void PrintInstructions()
    {
        Debug.Log("Instructions: ");
        Debug.Log("Start playing!");
        Debug.Log("Move with ASWD ");
    }

    bool IsPlaying()
    {
        Debug.Log("Instructions: ");
        return true;
    }
}
