using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_PlayerMovement : MonoBehaviour
{
    private float _movementSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * (_movementSpeed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * (_movementSpeed * Time.deltaTime));
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * (_movementSpeed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * (_movementSpeed * Time.deltaTime));
        }
    }
}
