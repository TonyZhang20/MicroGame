using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.FPS.Game;
using System;

public class PlayerHit : MonoBehaviour
{
    private bool isStart;
    private GameObject player;
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            player = other.gameObject;

            if(isStart == false)
            {
                isStart = true;
                StartCoroutine(HitPlayer());
            }
        }
    }

    IEnumerator HitPlayer()
    {
        player.GetComponent<Health>().OnDamaged?.Invoke(5, null);
        player.GetComponent<Health>().TakeDamage(5, null);
        yield return new WaitForSeconds(0.2f);
        isStart = false;
        Debug.Log("Send hit");
    }
}
