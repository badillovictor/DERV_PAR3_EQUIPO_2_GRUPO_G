using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManagerHealthBar : MonoBehaviour
{
    private Image _healthValue;
    private float _damage;
    private float _health;
    private TextMeshProUGUI _GameOverText;
    
    // Start is called before the first frame update
    void Start()
    {
        _health = 1.0f;
        _healthValue = GameObject.Find("HealthBar").GetComponent<Image>();
        _healthValue.fillAmount = _health;
        _GameOverText= GameObject.Find("txtGameOver").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _damage = Random.Range(0.1f, 0.9f);
            _health -= _damage;
            _healthValue.fillAmount = _health;
        }

        if (_health <= 0)
        {
            _GameOverText.text = "Tas Morido";
        }
    }
}
