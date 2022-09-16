using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicroEnemyController : MonoBehaviour
{

    public ParticleSystem particle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            particle.Play();
        }
    }
}



