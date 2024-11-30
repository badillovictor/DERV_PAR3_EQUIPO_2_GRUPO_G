using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class P11_SpikesTrigger : MonoBehaviour
{
    private P11_ManagerHealthBar healthBar;

    private void Start()
    {
        healthBar = GameObject.Find("HandlerHealthBar").GetComponent<P11_ManagerHealthBar>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (!other.CompareTag("Player")){ return; }
        healthBar.GetDamaged(0.001f);
    }
}
