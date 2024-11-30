using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P11_CamaraMouseRotation : MonoBehaviour
{
    private Transform _playerView;
    private float _velocity;
    private float anguloX;
    private float anguloY;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        _playerView = GameObject.Find("Player").transform;
        _velocity = 5.0f;
        anguloX = 0;
        anguloY = 0;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        float valY = Input.GetAxis("Mouse Y");
        float valYwithVelocity = valY * _velocity;
        float valX = Input.GetAxis("Mouse X");
        float valXwithVelocity = valX * _velocity;
        anguloX -= valYwithVelocity;
        anguloX = Mathf.Clamp(anguloX,-45f, 45f);
        anguloY -= valXwithVelocity;
        _playerView.localRotation = Quaternion.Euler(anguloX, -anguloY, 0f);

    }
}
