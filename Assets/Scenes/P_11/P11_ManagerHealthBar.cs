using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P11_ManagerHealthBar : MonoBehaviour
{
    private P11_ManagerCamera _camera;
    private Image _healthValue;
    private float _damage;
    private float _health;
    private bool _isDead;

    private void Awake()
    {
        _healthValue = GameObject.Find("HealthBar").GetComponent<Image>();
        _camera = GameObject.Find("HandlerCamera").GetComponent<P11_ManagerCamera>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _health = 1.0f;
        _healthValue.fillAmount = _health;
    }

    public void GetDamaged(float damage)
    {
        if (_health > 0)
        {
            _health -= damage;
            _healthValue.fillAmount = _health;
        }
        else if (!_isDead)
        {
            _camera.StartCoroutine("Shake");
            _isDead = true;
        }
    }
}
