using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerCamera : MonoBehaviour
{
    private Transform _camera;
    private float _shakeDuration;
    private float _shakeIntensity;
    private float _elapsedTime;
    
    // Start is called before the first frame update
    void Start()
    {
        _camera = GameObject.Find("Main Camera").transform;
        _shakeDuration = 2.0f;
        _shakeIntensity = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            StartCoroutine("Shake");
        }
    }

    IEnumerator Shake()
    {
        Vector3 originalPos = _camera.position;
        _elapsedTime = 0.0f;
        float x, y;
        while (_elapsedTime < _shakeDuration)
        {
            x = Random.Range(-1f, 1f) * _shakeIntensity;
            y = Random.Range(-1f, 1f) * _shakeIntensity;
            
            _camera.position = new Vector3(originalPos.x + x, originalPos.y + y, originalPos.z);
            
            _elapsedTime += Time.deltaTime;
            
            yield return null;
        }
        
        _camera.position = originalPos;
    }
}
