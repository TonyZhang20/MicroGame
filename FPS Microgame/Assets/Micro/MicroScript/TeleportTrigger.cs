using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.FPS.Gameplay;

namespace Unity.FPS.Game
{
    public class TeleportTrigger : MonoBehaviour
    {
        public Vector3 targetPosition;
        public WeaponController weapon;
        private bool isDoorUsed = false;

        private void OnTriggerEnter(Collider other)
        {

            if (other.CompareTag("Player") && isDoorUsed == false)
            {
                isDoorUsed = true;

                other.GetComponent<CharacterController>().enabled = false;
                other.gameObject.transform.position = targetPosition;
                other.GetComponent<CharacterController>().enabled = true;
                other.gameObject.GetComponent<Health>().Heal(30f);

                other.GetComponent<PlayerWeaponsManager>()?.AddWeapon(weapon);
            }
        }

    }
}
