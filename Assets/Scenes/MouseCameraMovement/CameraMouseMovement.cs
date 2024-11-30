using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouseMovement : MonoBehaviour
{
    private Transform _camera;
    private float _velocity;
    private float anguloX;

    // Start is called before the first frame update
    void Start()
    {
        _camera = GameObject.Find("Main Camera").transform;
        _velocity = 2.0f;
        anguloX = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
        float valY = Input.GetAxis("Mouse Y");
        float valYwithVelocity = valY * _velocity;
        anguloX -= valYwithVelocity;
        anguloX = Mathf.Clamp(anguloX,-45f, 45f);
        _camera.localRotation = Quaternion.Euler(anguloX, 0f, 0f);

    }
}
